using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorService.Domain
{
    public interface IEquipmentValidator
    {
        ValidationResult Validate(int machineId, int[] equipmentIdArray,
            int[] jigIdArray, int[] materialIdArray, int[] carrierIdAddray);
    }
}
