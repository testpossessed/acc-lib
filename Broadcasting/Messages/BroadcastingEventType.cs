﻿using System;

namespace Acc.Lib.Broadcasting.Messages;

public enum BroadcastingEventType
{
    None = 0,
    GreenFlag = 1,
    SessionOver = 2,
    PenaltyCommMsg = 3,
    Accident = 4,
    LapCompleted = 5,
    BestSessionLap = 6,
    BestPersonalLap = 7
};