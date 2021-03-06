﻿using MachineSteps.Models.Actions;
using MachineSteps.Models.Enums;
using MachineSteps.Models.Steps;
using MachineSteps.Plugins.IsoConverterBase;
using MachineSteps.Plugins.IsoInterpreter.Attributes;
using MachineSteps.Plugins.IsoIstructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSteps.Plugins.IsoInterpreter.Converters.M
{
    [MIstructionConverter(121)]
    public class M121Converter : MIstructionConverter<State>
    {
        public override List<MachineStep> Convert(MIstruction istruction, State state)
        {
            return new List<MachineStep>
            {
                new MachineStep()
                {
                    Id = GetStepId(),
                    Name = "M121",
                    Actions = new List<BaseAction>()
                    {
                        new TwoPositionLinkAction()
                        {
                            LinkId = 3101,
                            RequestedState = TwoPositionLinkActionRequestedState.On
                        }
                    }
                }
            };
        }
    }
}
