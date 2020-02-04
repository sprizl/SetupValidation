using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidatorService.Domain
{
    public class FTEquipmentValidator : IEquipmentValidator
    {
        public ValidationResult Validate(int machineId, int[] equipmentIdArray, int[] jigIdArray, int[] materialIdArray, int[] carrierIdAddray)
        {
            return new ValidationResult(true, "Mockup validate is completed");
        }
    }
}