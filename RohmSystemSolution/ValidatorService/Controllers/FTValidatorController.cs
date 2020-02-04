using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ValidatorService.Application;
using ValidatorService.Domain;

namespace ValidatorService.Controllers
{
    public class FTValidatorController : ApiController
    {

        public FTValidatorController() {

        }

        // POST api/FTValidator/TestValidate
        [HttpPost]
        public IHttpActionResult TestValidate([FromBody] TestValidateDto testValidateDto)
        {
            FTEquipmentValidator validator = new FTEquipmentValidator();

            var result = validator.Validate(testValidateDto.MachineId, testValidateDto.EquipmentIdArray, 
                testValidateDto.JigIdArray, testValidateDto.MaterialIdArray, testValidateDto.CarrierIdArray);

            return Ok(result);
        }
    }
}
