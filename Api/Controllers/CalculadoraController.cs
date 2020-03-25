using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Features;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        /// <summary>
        /// Soma dois ou mais numeros
        /// </summary>
        /// <param name="request">OperationRequest, objeto contendo a lista de números</param>
        /// <returns>Resultado da soma</returns>
        [HttpPost("somar")]
        public ContentResult Somar([FromBody] OperationRequest request)
        {
            try
            {
                decimal resultado = Calculadora.Somar(request.Numbers);

                return new ContentResult
                {
                    StatusCode = 200,
                    Content = resultado.ToString()
                };
            }
            catch (Exception ex)
            {
                return new ContentResult
                {
                    StatusCode = 500,
                    Content = ex.Message
                };
            }
        }

        /// <summary>
        /// Subtrai de dois ou mais numeros
        /// </summary>
        /// <param name="request">OperationRequest, objeto contendo a lista de números</param>
        /// <returns>Resultado da subtração</returns>
        [HttpPost("subtrair")]
        public ContentResult Subtrair([FromBody] OperationRequest request)
        {
            try
            {
                decimal resultado = Calculadora.Subtrair(request.Numbers);

                return new ContentResult
                {
                    StatusCode = 200,
                    Content = resultado.ToString()
                };
            }
            catch (Exception ex)
            {
                return new ContentResult
                {
                    StatusCode = 500,
                    Content = ex.Message
                };
            }
        }

        /// <summary>
        /// Multiplica dois ou mais numeros
        /// </summary>
        /// <param name="request">OperationRequest, objeto contendo a lista de números</param>
        /// <returns>Resultado da multiplicação</returns>
        [HttpPost("multiplicar")]
        public ContentResult Multiplicar([FromBody] OperationRequest request)
        {
            try
            {
                decimal resultado = Calculadora.Multiplicar(request.Numbers);

                return new ContentResult
                {
                    StatusCode = 200,
                    Content = resultado.ToString()
                };
            }
            catch (Exception ex)
            {
                return new ContentResult
                {
                    StatusCode = 500,
                    Content = ex.Message
                };
            }
        }

        /// <summary>
        /// Divide dois numeros
        /// </summary>
        /// <param name="request">DivisionRequest, objeto contendo os números para a divisão</param>
        /// <returns>Resultado da divisão</returns>
        [HttpPost("dividir")]
        public ContentResult Dividir([FromBody] DivisionRequest request)
        {
            try
            {
                decimal resultado = Calculadora.Dividir(request.V1, request.V2);

                return new ContentResult
                {
                    StatusCode = 200,
                    Content = resultado.ToString()
                };
            }
            catch (Exception ex)
            {
                return new ContentResult
                {
                    StatusCode = 500,
                    Content = ex.Message
                };
            }
        }
    }
}