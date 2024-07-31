using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using NetProjectSithec.Models;


namespace NetProjectSithec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        [HttpGet("calculate")]
        public IActionResult CalculateFromHeaders(
            [FromHeader(Name = "Number1")] double number1,
            [FromHeader(Name = "Number2")] double number2,
            [FromHeader(Name = "Number3")] double number3)
        {
            double sum = number1 + number2 + number3;
            double rest = number1 - number2 - number3;
            double multiply = number1 * number2 * number3;
            double divide = 0;
            if (number1 == 0 || number2 == 0 || number2 == 0)
                return BadRequest("No se puede dividir por cero.");
            else
                divide = number1 / number2 / number3;

            string result = $"Suma: {sum}, Resta: {rest}, Multiplicación: {multiply}, División: {divide}";
            return Ok(result);
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromQuery] Operations request)
        {
            double sum = request.Number1 + request.Number2 + request.Number3;
            double rest = request.Number1 - request.Number2 - request.Number3;
            double multiply = request.Number1 * request.Number2 * request.Number3;
            double divide;
            if(request.Number1 == 0 || request.Number2 == 0 || request.Number3 == 0)
                return BadRequest("No se puede dividir por cero.");
            else
                divide = request.Number1 / request.Number2 / request.Number3;

            string result = $"Suma: {sum}, Resta: {rest}, Multiplicación: {multiply}, División: {divide}";
            return Ok(result);
        }

        [HttpPost("calculateBody")]
        public IActionResult CalculateFromBody([FromBody] Operations request)
        {
            double sum = request.Number1 + request.Number2 + request.Number3;
            double rest = request.Number1 - request.Number2 - request.Number3;
            double multiply = request.Number1 * request.Number2 * request.Number3;
            double divide;
            if (request.Number1 == 0 || request.Number2 == 0 || request.Number3 == 0)
                return BadRequest("No se puede dividir por cero.");
            else
                divide = request.Number1 / request.Number2 / request.Number3;

            string result = $"Suma: {sum}, Resta: {rest}, Multiplicación: {multiply}, División: {divide}";
            return Ok(result);
        }

    }
}
