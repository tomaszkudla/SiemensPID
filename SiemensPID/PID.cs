using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensPID
{
    /// <summary>
    /// PID controller from Siemens Step 7 library (FB41 CONT_C) - code from http://plc4good.org.ua/view_post.php?id=51 translated to C#
    /// </summary>
    class PID
    {

        //INPUT
        /// <summary>
        /// COMPLETE RESTART
        /// The block has a complete restart routine that is processed when the input “complete restart” is set.
        /// </summary>
        public bool COM_RST;

        /// <summary>
        /// MANUAL VALUE ON If the input “manual value on” is set, the control loop is interrupted. A manual value is set as the manipulated value.
        /// </summary>
        public bool MAN_ON = true;

        /// <summary>
        /// PROCESS VARIABLE PERIPHERAL ON If the process variable is read from the I/Os, the input PV_PER must be connected to the I/Os and the input “process variable peripheral on” must be set.
        /// </summary>
        public bool PVPER_ON;

        /// <summary>
        /// PROPORTIONAL ACTION ON The PID actions can be activated or deactivated individually in the PID algorithm.The P action is on when the input “proportional action on” is set.
        /// </summary>
        public bool P_SEL = true;

        /// <summary>
        /// NTEGRAL ACTION ON The PID actions can be activated or deactivated individually in the PID algorithm.The I action is on when the input “integral action on” is set.
        /// </summary>
        public bool I_SEL = true;

        /// <summary>
        /// INTEGRAL ACTION HOLD The output of the integrator can be “frozen” by setting the input “integral action hold”.
        /// </summary>
        public bool INT_HOLD;

        /// <summary>
        /// INITIALIZATION OF THE INTEGRAL ACTION The output of the integrator can be connected to the input I_ITL_VAL by setting the input “initialization of the integral action on”.
        /// </summary>
        public bool I_ITL_ON;

        /// <summary>
        /// DERIVATIVE ACTION ON The PID actions can be activated or deactivated individually in the PID algorithm.The D action is on when the input “derivative action on” is set.
        /// </summary>
        public bool D_SEL;

        /// <summary>
        /// SAMPLING TIME The time between the block calls must be constant.The “sampling time” input specifies the time between block calls.
        /// </summary>
        public double CYCLE = 1.0;

        /// <summary>
        /// INTERNAL SETPOINT The “internal setpoint” input is used to specify a setpoint.
        /// </summary>
        public double SP_INT;

        /// <summary>
        /// PROCESS VARIABLE IN An initialization value can be set at the “process variable in” input or an external process variable in floating point format can be connected.
        /// </summary>
        public double PV_IN;

        /// <summary>
        /// PROCESS VARIABLE PERIPHERAL The process variable in the I/O format is connected to the controller at the “process variable peripheral” input.
        /// </summary>
        public int PV_PER;

        /// <summary>
        /// MANUAL VALUE The “manual value” input is used to set a manual value using the operator interface functions.
        /// </summary>
        public double MAN;

        /// <summary>
        /// PROPORTIONAL GAIN The “proportional value” input specifies the controller gain.
        /// </summary>
        public double GAIN = 2.0;

        /// <summary>
        /// RESET TIME The “reset time” input determines the time response of the integrator.
        /// </summary>        
        public double TI = 20.0;

        /// <summary>
        /// DERIVATIVE TIME The “derivative time” input determines the time response of the derivative unit.
        /// </summary>
        public double TD = 10.0;

        /// <summary>
        /// TIME LAG OF THE DERIVATIVE ACTION The algorithm of the D action includes a time lag that can be assigned at the “time lag of the derivative action” input.
        /// </summary>
        public double TM_LAG = 2.0;

        /// <summary>
        /// DEAD BAND WIDTH A dead band is applied to the error.The “dead band width” input determines the size of the dead band.
        /// </summary>
        public double DEADB_W;

        /// <summary>
        /// MANIPULATED VALUE HIGH LIMIT The manipulated value is always limited by an upper and lower limit. The “manipulated value high limit”input specifies the upper limit.
        /// </summary>
        public double LMN_HLM = 100.0;

        /// <summary>
        /// MANIPULATED VALUE LOW LIMIT The manipulated value is always limited by an upper and lower limit. The “manipulated value low limit” input specifies the lower limit.
        /// </summary>
        public double LMN_LLM;

        /// <summary>
        /// PROCESS VARIABLE FACTOR The “process variable factor” input is multiplied by the process variable. The input is used to adapt the process variable range.
        /// </summary>
        public double PV_FAC = 1;

        /// <summary>
        /// PROCESS VARIABLE OFFSET The “process variable offset” input is added to the process variable. The input is used to adapt the process variable range.
        /// </summary>
        public double PV_OFF;

        /// <summary>
        /// MANIPULATED VALUE FACTOR The “manipulated value factor” input is multiplied by the manipulated value. The input is used to adapt the manipulated value range.
        /// </summary>
        public double LMN_FAC = 1;

        /// <summary>
        /// MANIPULATED VALUE OFFSET The “manipulated value offset” is added to the manipulated value. The input is used to adapt the manipulated value range.
        /// </summary>
        public double LMN_OFF;

        /// <summary>
        /// INITIALIZATION VALUE OF THE INTEGRAL ACTION The output of the integrator can be set at input I_ITL_ON. The initialization value is applied to the input “initialization value of the integral action”.
        /// </summary>
        public double I_ITLVAL;

        /// <summary>
        /// DISTURBANCE VARIABLE For feedforward control, the disturbance variable is connected to input “disturbance variable”.
        /// </summary>
        public double DISV;

    //OUTPUT

        /// <summary>
        /// MANIPULATED VALUE The effective manipulated value is output in floating point format at the “manipulated value” output.
        /// </summary>
        public double LMN { get; private set; }

        /// <summary>
        /// MANIPULATED VALUE PERIPHERAL The manipulated value in the I/O format is connected to the controller at the “manipulated value peripheral” output.
        /// </summary>
        public int LMN_PER { get; private set; }

        /// <summary>
        /// HIGH LIMIT OF MANIPULATED VALUE REACHED The manipulated value is always limited to an upper and lower limit. The output “high limit of manipulated value reached” indicates that the upper limit has been exceeded.
        /// </summary>
        public bool QLMN_HLM { get; private set; }

        /// <summary>
        /// LOW LIMIT OF MANIPULATED VALUE REACHED The manipulated value is always limited to an upper and lower limit. The output “low limit of manipulated value reached” indicates that the lower limit has been exceeded.
        /// </summary>
        public bool QLMN_LLM { get; private set; }

        /// <summary>
        /// PROPORTIONAL COMPONENT The “proportional component” output contains the proportional component of the manipulated variable.
        /// </summary>
        public double LMN_P { get; private set; }

        /// <summary>
        /// INTEGRAL COMPONENT The “integral component” output contains the integral component of the manipulated value.
        /// </summary>
        public double LMN_I { get; private set; }

        /// <summary>
        /// DERIVATIVE COMPONENT The “derivative component” output contains the derivative component of the manipulated value.
        /// </summary>
        public double LMN_D { get; private set; }

        /// <summary>
        /// PROCESS VARIABLE The effective process variable is output at the “process variable” output.
        /// </summary>
        public double PV { get; private set; }

        /// <summary>
        /// ERROR SIGNAL The effective error is output at the “error signal” output.
        /// </summary>
        public double ER { get; private set; }                

        //VAR

        double sInvAlt;           
        double sIanteilAlt;          
        double sRestInt;          
        double sRestDif;                
        double sRueck;               
        double sLmn;                  
        bool sbArwHLmOn;            //Output max reached
        bool sbArwLLmOn;            //Output min reached 
        bool sbILimOn = true;

        //VAR_TEMP

        double Hvar;                //Ancillary variable
        double rCycle;              //Cycle time in seconds
        double Diff;                //Difference
        double Istwert;             //Process variable
        double ErKp;                //Error * gain 
        double rTi;                 //Integration time in seconds
        double rTd;                 //Derivation time in seconds
        double rTmLag;              //Derivation lag in seconds
        double Panteil;             //P component
        double Ianteil;             //I component
        double Danteil;             //D component
        double Verstaerk;           //Gain
        double RueckDiff;           //Difference for D component
        double RueckAlt;            //Old derivative
        double dLmn;                //Controller's output
        double gf;                  //Ancillary variable
        double rVal;                //Ancillary variable

        
        public void Go()
        {

            if (COM_RST)
            {
                //Clearing fields
                sIanteilAlt= I_ITLVAL;
                LMN= 0.0;                     
                QLMN_HLM= false;              
                QLMN_LLM= false;             
                LMN_P= 0.0;                   
                LMN_I= 0.0;                   
                LMN_D= 0.0;                   
                LMN_PER= 0;                   
                PV= 0.0;                      
                ER= 0.0;                  
                sInvAlt= 0.0;
                sRestInt= 0.0;
                sRestDif= 0.0;
                sRueck= 0.0;
                sLmn= 0.0;
                sbArwHLmOn= false;
                sbArwLLmOn= false;

            }
            else
            {
                rCycle= CYCLE / 1000.0;  //Cycle time in seconds
                Istwert = PV_PER * 100.0 / 27648.0;  //Scaling raw value from digital inputs module
                Istwert= Istwert * PV_FAC + PV_OFF;  //Computing corrected PV
                if (!PVPER_ON) Istwert= PV_IN;  //If raw value form DI module is not enabled, takes value from PV_IN
                PV = Istwert;                                                   
                ErKp= SP_INT - PV;  //Error computing
                if (ErKp< (-DEADB_W))  ER= ErKp + DEADB_W;  //Error computing with deadband
                else if (ErKp > DEADB_W) ER= ErKp - DEADB_W;            
                else ER= 0.0;                      
               
                ErKp= ER * GAIN;   
                rTi= TI/ 1000.0;  //Integration time in seconds
                rTd= TD / 1000.0;  //Derivation time in seconds
                rTmLag= TM_LAG / 1000.0;  //Derivation lag time in seconds
                //Checking controller parameters
                if (rTi< (rCycle* 0.5)) rTi= rCycle * 0.5;  //Minimum integration time = cycle time / 2
                if (rTd<rCycle) rTd= rCycle;  //Minimum derivation time = cycle time
                if (rTmLag<rCycle *0.5) rTmLag= rCycle * 0.5; //Minimum derivartion lag = cycle time / 2

                //---------------------------------------------------------------------------------------------
                // Calculating P component
                //---------------------------------------------------------------------------------------------    
                if (P_SEL)
                {
                    Panteil= ErKp;  //If P component enabled
                }
                else
                {
                    Panteil= 0.0;
                }

                //---------------------------------------------------------------------------------------------
                // Calculating I component
                //---------------------------------------------------------------------------------------------    

                if (I_SEL)  //If I component enabled
                {
                    if (I_ITL_ON)  //I component initialization
                    {
                        Ianteil = I_ITLVAL;
                        sRestInt = 0.0;
                    }
                    else
                    {
                        if (MAN_ON)  //Manual mode
                        {
                            Ianteil = sLmn - Panteil - DISV;
                            sRestInt = 0.0;
                        }
                        else  //Auto mode
                        {
                            Diff = rCycle / rTi * (ErKp + sInvAlt) * 0.5 + sRestInt;
                            if (((Diff > 0.0) && sbArwHLmOn || INT_HOLD) || ((Diff < 0.0) && sbArwLLmOn))
                            {
                                Diff= 0.0;
                            }
                            Ianteil= sIanteilAlt + Diff;
                            sRestInt= sIanteilAlt - Ianteil + Diff;
                        }
                    }
                }
                else
                {
                    Ianteil = 0.0;
                    sRestInt = 0.0;
                }

                //---------------------------------------------------------------------------------------------
                //Calculating D component
                //---------------------------------------------------------------------------------------------    
                Diff= ErKp;
                if ((!MAN_ON) && D_SEL)
                {
                    Verstaerk= rTd / (rCycle * 0.5 + rTmLag);
                    Danteil= (Diff - sRueck) * Verstaerk;
                    RueckAlt= sRueck;
                    RueckDiff= rCycle / rTd * Danteil + sRestDif;
                    sRueck= RueckDiff + RueckAlt;
                    sRestDif= RueckAlt - sRueck + RueckDiff;
                }
                else
                {
                    Danteil= 0.0;
                    sRestDif= 0.0;
                    sRueck= Diff;
                }

                //---------------------------------------------------------------------------------------------
                //Computing output
                //---------------------------------------------------------------------------------------------
                dLmn= Panteil + Ianteil + Danteil + DISV;
                if (MAN_ON)  
                {
                    dLmn= MAN;  //Output in manual mode
                    LMN = dLmn;
                }
                else
                {
                    if ((!I_ITL_ON) && I_SEL)
                    {
                        if ((Ianteil > (LMN_HLM - DISV)) && (dLmn > LMN_HLM) && ((dLmn - LMN_D) > LMN_HLM))
                        {
                            rVal= LMN_HLM - DISV;
                            gf= dLmn - LMN_HLM;
                            rVal= Ianteil - rVal;
                            if (rVal > gf) rVal= gf;
                            Ianteil= Ianteil - rVal;
                        }
                        else
                        {
                            if ((Ianteil < (LMN_LLM - DISV)) && (dLmn < LMN_LLM) && ((dLmn - LMN_D) < LMN_LLM))
                            {
                                rVal= LMN_LLM - DISV;
                                gf= dLmn - LMN_LLM;
                                rVal= Ianteil - rVal;
                                if (rVal<gf) rVal= gf;
                                Ianteil= Ianteil - rVal;


                            }
                        }
                    }

                    LMN_P= Panteil;
                    LMN_I= Ianteil;
                    LMN_D= Danteil;
                    sInvAlt= ErKp;
                    sIanteilAlt= Ianteil;
                    sbArwHLmOn= false;
                    sbArwLLmOn= false;

                    if (dLmn >= LMN_HLM)
                    {
                        QLMN_HLM= true;
                        QLMN_LLM= false;
                        dLmn= LMN_HLM;
                        sbArwHLmOn= true;
                    }
                    else
                    {
                        QLMN_HLM= false;
                        if (dLmn<= LMN_LLM)
                        {
                            QLMN_LLM= true;
                            dLmn= LMN_LLM;
                            sbArwLLmOn= true;
                        }
                        else
                        {
                            QLMN_LLM= false;
                        }

                    }

                    sLmn= dLmn;
                    dLmn= sLmn * LMN_FAC + LMN_OFF;
                    LMN= dLmn;
                    dLmn= LMN * 2.764800e+002;

                    if (dLmn >= 3.251100e+004)
                    {
                        dLmn= 3.251100e+004;
                    }
                    else
                    {
                        if (dLmn <= -3.251200e+004)
                        {
                            dLmn= -3.251200e+004;
                        }         
                    }
                    LMN_PER= (int)dLmn;
                }
            }
            
        }
        
    }
}
