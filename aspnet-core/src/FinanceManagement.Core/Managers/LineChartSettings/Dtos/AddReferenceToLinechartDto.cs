﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManagement.Managers.LineChartSettings.Dtos
{
    public class AddReferenceToLinechartDto
    {
        public long LinechartId { get; set; }
        public long ReferenceId { get; set; }
    }
}
