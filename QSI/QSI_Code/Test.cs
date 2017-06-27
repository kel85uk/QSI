﻿using QuantumRuntime;
using QuantumRuntime.Operator;
using static QuantumRuntime.ControlStatement;
using static QuantumRuntime.Operator.E;
using static QuantumRuntime.Operator.M;
using static QuantumRuntime.Operator.U;
using static QuantumRuntime.Quantum;
using static QuantumRuntime.Registers;

namespace QSI.QSI_Code
{
    class Test : QEnv
    {
        public Reg r1 = new Reg("r1");
        //public Reg r2 = new Reg("r2");
        //public Reg r3 = new Reg("r3");

        //public QReg qOutput = new QReg();
        public Quantum LooperQ = MakeDensityOperator("{[1 0;0 0]}");
        public Quantum q1 = MakeQBit("{[1/sqrt(2); 1/sqrt(2)]}");
        public Quantum Bob1 = MakeDensityOperator("{[0.5 0.5;0.5 0.5]}");//1/2(|0>+|1>)
        public Quantum Bob2 = MakeDensityOperator("{[1 0;0 0]}");
        U.Emit hGate = MakeU("{[1/sqrt(2) 1/sqrt(2); 1 / sqrt(2)  -1 / sqrt(2)]}");
        U.Emit CNot = MakeU("{[1 0 0 0;0 1 0 0;0 0 0 1;0 0 1 0]}");//1->2 Cnot
        U.Emit xGate = MakeU("{[0 1; 1 0]}");

        U.Emit zGate = MakeU("{[1 0;0 -1]}");

        M.Emit m = MakeM("{[1 0;0 0],[0 0;0 1]}");

        protected override void run()
        {
            hGate(q1);
            Register(r1, m(q1));
        }
    }
}
