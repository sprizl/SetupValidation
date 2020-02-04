using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidatorService.Application
{
    public class TestValidateDto
    {
        public int MachineId { get; set; }
        public int[] EquipmentIdArray { get; set; }
        public int[] JigIdArray { get; set; }
        public int[] MaterialIdArray { get; set; }
        public int[] CarrierIdArray { get; set; }
    }
}