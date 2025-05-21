using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace P100x_Ns
{
    public class P100x
    {

        //Return Code'

        public const uint NoError = 0;
        public const uint DriverHandleError = 1;
        public const uint DriverCallError = 2;
        public const uint AdControllerError = 3;
        public const uint ConfigCodeError = 4;
        public const uint DriverNoOpen = 5;
        public const uint AdPollingTimeOut = 6;
        public const uint FindBoardError = 7;
        public const uint AdChannelError = 8;
        public const uint DaChannelError = 9;
        public const uint InvalidateDelay = 10;
        public const uint DelayTimeOut = 11;
        public const uint InvalidateData = 12;
        public const uint TimeoutError = 13;
        public const uint ExceedBoardNumber = 14;
        public const uint NotFoundBoard = 15;
        public const uint OpenError = 16;
        public const uint FindTwoBoardError = 17;
        public const uint GetIntCountError = 18;
        public const uint InstallIrqError = 19;
        public const uint AllocateMemoryError = 20;
        public const uint RemoveIrqError = 21;
        public const uint ClearIntCountError = 22;
        public const uint BoardNotFound = 23;
        public const uint InstallEventError = 24;
        public const uint GetDataFromDriverFailed = 25;

        //***************************'
        //   Test Function           '
        //***************************'

        [DllImport("P100X.dll", EntryPoint = "P100X_ShortSub")]
        public static extern ushort ShortSub(ushort a, ushort b);

        [DllImport("P100X.dll", EntryPoint = "P100X_FloatSub")]
        public static extern float FloatSub(float a, float b);

        [DllImport("P100X.dll", EntryPoint = "P100X_GetDllVersion")]
        public static extern ushort GetDllVersion();

        //***************************'
        //   Driver Function           '
        //***************************'

        [DllImport("P100X.dll", EntryPoint = "P100X_DriverInit")]
        public static extern ushort DriverInit(out ushort wTotalBoards);

        [DllImport("P100X.dll", EntryPoint = "P100X_DriverClose")]
        public static extern void DriverClose();

        [DllImport("P100X.dll", EntryPoint = "P100X_GetDriverVersion")]
        public static extern ushort GetDriverVersion(out ushort wDriverVersion);

        [DllImport("P100X.dll", EntryPoint = "P100X_GetIrqNo")]
        public static extern ushort GetIrqNo(out ushort IrqNo);

        [DllImport("P100X.dll", EntryPoint = "P100X_GetConfigAddressSpace")]
        public static extern ushort GetConfigAddressSpace(ushort wBoardNo, out ushort wAddress0, out ushort wAddress1, out ushort wAddress2);

        [DllImport("P100X.dll", EntryPoint = "P100X_ActiveBoard")]
        public static extern ushort ActiveBoard(ushort wBoardNo);

        [DllImport("P100X.dll", EntryPoint = "P100X_WhichBoardActive")]
        public static extern ushort WhichBoardActive();
        [DllImport("P100X.dll", EntryPoint = "P100X_SetupTimer")]

        public static extern void SetupTimer(ushort wChannel, ushort wCoef);
        [DllImport("P100X.dll", EntryPoint = "P100X_DelayTick")]
        public static extern short P100X_DelayTick(ushort wDownCount);

        //**********************
        //DO Function
        //**********************
        [DllImport("P100X.dll", EntryPoint = "P100X_DigitOut")]
        public static extern void DigitOut(uint wOutData);

        [DllImport("P100X.dll", EntryPoint = "P100X_DigitIn")]
        public static extern void DigitIn(out uint wDIData);

        //**********************
        //AD Function
        //**********************
        [DllImport("P100X.dll", EntryPoint = "P100X_ChScanEnable")]
        public static extern ushort ChScanEnable();

        [DllImport("P100X.dll", EntryPoint = "P100X_ChScanDisable")]
        public static extern ushort ChScanDisable();

        [DllImport("P100X.dll", EntryPoint = "P100X_SetChannelScan")]
        public static extern ushort SetChannelScan(out ushort wAdChannel, out ushort wConfig, ushort wTotalChannels);

        [DllImport("P100X.dll", EntryPoint = "P100X_SetChConfig")]
        public static extern ushort SetChConfig(ushort wAdChannel, ushort wConfig);

        [DllImport("P100X.dll", EntryPoint = "P100X_AdPollingH")]
        public static extern ushort AdPollingH(out ushort wAdVal);

        [DllImport("P100X.dll", EntryPoint = "P100X_AdPollingF")]
        public static extern float AdPollingF(out float fAdVal);

        [DllImport("P100X.dll", EntryPoint = "P100X_AdMultiPollingF")]
        public static extern ushort AdMultiPollingF(out float fAdVa, ushort wNum);

        [DllImport("P100X.dll", EntryPoint = "P100X_AdMultiPacerF")]
        public static extern ushort AdMultiPacerF(out float fAdVal, ushort wNum, ushort wSamplingDiv);

        //******************
        //Interrupt Function
        //*****************

        [DllImport("P100X.dll", EntryPoint = "P100X_IntInstall")]
        public static extern ushort IntInstall(out uint hEvent, uint dwCount);

        [DllImport("P100X.dll", EntryPoint = "P100X_IntStart")]
        public static extern ushort IntStart(ushort Ch, ushort Gain, ushort wFreqDiv);

        [DllImport("P100X.dll", EntryPoint = "P100X_IntStartExTrigger")]
        public static extern ushort IntStartExTrigger(ushort Ch, ushort Gain);

        [DllImport("P100X.dll", EntryPoint = "P100X_IntGetBufferH")]
        public static extern ushort IntGetBufferH(uint dwNum, out short wBuf);

        [DllImport("P100X.dll", EntryPoint = "P100X_IntGetBufferF")]
        public static extern ushort IntGetBufferF(uint dwNum, out float fAdVal);

        [DllImport("P100X.dll", EntryPoint = "P100X_IntGetCount")]
        public static extern ushort IntGetCount(ref uint dwVal);

        [DllImport("P100X.dll", EntryPoint = "P100X_IntStop")]
        public static extern ushort IntStop();

        [DllImport("P100X.dll", EntryPoint = "P100X_IntRemove")]
        public static extern ushort IntRemove();

        private int DriverOpened = 0;

        public P100x()//constroctor
        {
            DriverOpened = 0;
        }

        ~P100x()
        {
            if (DriverOpened != 0)
            {
                DriverOpened = 0;
                DriverClose();
            }
        }
    }
}
