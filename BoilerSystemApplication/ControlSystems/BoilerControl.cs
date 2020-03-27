using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlocksLibrary.Blocks;
using BlocksLibrary.Interfaces;
using BoilerSystem.ControlSystems;

namespace BoilerSystem.BoilerControl
{
    public class BoilerControl : ObjectControl
    {
        private double m_inputStream = 0;
        private double m_outputStream = 0;

        public double InputStream
        {
            get { return m_inputStream; }
            set
            {
                if (value < 0)
                {
                    m_inputStream = 0;
                }
                else if (value > Settings.MaxInputStream)
                {
                    m_inputStream = Settings.MaxInputStream;
                }
                else
                {
                    m_inputStream = value;
                }
            }
        }

        public double OutputStream
        {
            get { return m_outputStream; }
            set
            {
                if (value < 0)
                {
                    m_outputStream = 0;
                }
                else if (value > Settings.MaxOutputStream)
                {
                    m_outputStream = Settings.MaxOutputStream;
                }
                else
                {
                    m_outputStream = value;
                }
            }
        }

        public double WaterLevel { get; set; }

        public BoilerControl(double dt) : base() 
        {
            DT = dt;
            InputStream = 0;

            var blocks = new Queue<IBlock>();

            blocks.Enqueue(new DelayBlock(dt, Settings.Delay));
            blocks.Enqueue(new GainBlock(Settings.Gain1));
            blocks.Enqueue(new GainBlock(Settings.Gain2));
            blocks.Enqueue(new IntegralBlock(dt));
            blocks.Enqueue(new InterferenceBlock(Settings.Interference));
            Object = new ComplexBlock(blocks);
        }

        public double CalculateWaterLevel()
        {
            var inputValue = InputStream - OutputStream;
            //todo valves coefs
            var result = Object.Calculate(inputValue) + inputValue;

            WaterLevel = result;

            if (WaterLevel <= 0 && inputValue < 0)
            {
                WaterLevel = 0;

                foreach (var block in Object.Blocks)
                {
                    var integralBlock = block as IntegralBlock;

                    if (integralBlock != null)
                    {
                        integralBlock.StepBackAtLimitValue();
                    }
                }
            }

            if (WaterLevel >= Settings.WaterLevelLimit && inputValue > 0)
            {
                WaterLevel = Settings.WaterLevelLimit;

                foreach (var block in Object.Blocks)
                {
                    var integralBlock = block as IntegralBlock;

                    if (integralBlock != null)
                    {
                        integralBlock.StepBackAtLimitValue();
                    }
                }
            }

            Time += DT;

            return WaterLevel;
        }

        public void RefreshSystem()
        {
            WaterLevel = 0;
            Time = 0;

            foreach(var block in Object.Blocks)
            {
                var temp = block as IRefreshable;
                if (temp != null)
                {
                    temp.Refresh();
                }
            }
        }
    }
}
