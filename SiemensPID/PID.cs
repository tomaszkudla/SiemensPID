using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensPID
{
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
        bool sbArwHLmOn;                              //Osiągnięto max wyjścia
        bool sbArwLLmOn;                             //Osiągnięto min wyjścia 
        bool sbILimOn = true;

        //VAR_TEMP

        double Hvar;                                   //Zmienna pomocnicza
        double rCycle;                                  //Czas cyklu w sekundach
        double Diff;                                    //Różnica
        double Istwert;                                //Wartość mierzona
        double ErKp;                                   //Uchyb * wzmocnienie 
        double rTi;                                  //Czas całkowania w sekundach
        double rTd;                                  //Czas różniczkowania w sekundach
        double rTmLag;                               //Opóźnienie różniczkowania w sekundach
        double Panteil;                             //Komponent P
        double Ianteil;                             //Komponent I
        double Danteil;                           //Komponent D
        double Verstaerk;                          //Wzmocnienie
        double RueckDiff;                            //Różnica do komponentu D
        double RueckAlt;                             //Stara pochodna
        double dLmn;                              //Wyjście regulatora
        double gf;                                //Zmienna pomocnicza
        double rVal;                                  //Zmienna pomocnicza

        //BEGIN

        public void Go()
        {

            if (COM_RST)
            {
                // Wyczyść zmienne
                sIanteilAlt= I_ITLVAL;
                LMN= 0.0;                                       //Wartość wyjściowa
                QLMN_HLM= false;                                    //Górna granica wyjścia osiągnięta
                QLMN_LLM= false;                                    //Dolna granica wyjścia osiągnięta
                LMN_P= 0.0;                                     //Komponent P
                LMN_I= 0.0;                                     //Komponent I
                LMN_D= 0.0;                                     //Komponent D
                LMN_PER= 0;                                     //Wartość wyjściowa do modułu AO
                PV= 0.0;                                        //Wartość mierzona
                ER= 0.0;                                        //Uchyb
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
                rCycle= CYCLE / 1000.0; // Czas realizacji bloku w sekundacch
                Istwert = PV_PER * 100.0 / 27648.0;    // Pobiera wartość mierzoną z modułu
                Istwert= Istwert * PV_FAC + PV_OFF;                             // Wartość mierzona skorygowana
                if (!PVPER_ON) Istwert= PV_IN;                    // Jeśli wartość mierzona z modułu wyłączona - wziąć zmienną z PV_IN
                PV = Istwert;                                                   // Wartość mierzona
                ErKp= SP_INT - PV;                                              // Uchyb
                if (ErKp< (-DEADB_W))  ER= ErKp + DEADB_W;             // Jeśli uchyb większy od strefy nieczułości
                else if (ErKp > DEADB_W) ER= ErKp - DEADB_W;             // Zmniejszenie uchybu o strefę nieczułości
                else ER= 0.0;                      // Zerowanie uchybu w strefie nieczułości
               
                ErKp= ER * GAIN;                                                // Uchyb * wzmocnienie
                rTi= TI/ 1000.0;                   // Czas całkowania w sekundach
                rTd= TD / 1000.0;                   // Czas różniczkowania w sekundach
                rTmLag= TM_LAG / 1000.0;            // Czas opóźnienia różniczkowania w sekundach
                                                                                 // Sprawdź dopuszczalny czas regulatora
                if (rTi< (rCycle* 0.5)) rTi= rCycle * 0.5; // Minimalny czas całkowania - czas cyklu / 2
                if (rTd<rCycle) rTd= rCycle; // Minimalny czas różniczkowania - czas cyklu
                if (rTmLag<rCycle *0.5) rTmLag= rCycle * 0.5; // Minimalne opóźnienie różniczkowania - czas cyklu / 2

                //---------------------------------------------------------------------------------------------
                // Obliczenie komponentu P
                //---------------------------------------------------------------------------------------------    
                if (P_SEL)
                {
                    Panteil= ErKp;                                              // Jeśli załączony komponent P
                }
                else
                {
                    Panteil= 0.0;
                }

                //---------------------------------------------------------------------------------------------
                // Obliczenie komponentu I
                //---------------------------------------------------------------------------------------------    

                if (I_SEL) //Jeśli załączony komponent I
                {
                    if (I_ITL_ON) //Inicjalizacja komponentu I
                    {
                        Ianteil = I_ITLVAL;
                        sRestInt = 0.0;
                    }
                    else
                    {
                        if (MAN_ON) //Tryb ręczny
                        {
                            Ianteil = sLmn - Panteil - DISV;
                            sRestInt = 0.0;
                        }
                        else     //Tryb auto
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
                //Obliczanie komponentu D
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
                //Wypracowanie wyjścia
                //---------------------------------------------------------------------------------------------
                dLmn= Panteil + Ianteil + Danteil + DISV;
                if (MAN_ON)   // Jeśli tryb ręczny
                {
                    dLmn= MAN;      // Wyjście w trybie ręcznym
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
