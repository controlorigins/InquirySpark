using InquirySpark.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace InquirySpark.WebApi.Helpers;


/// <summary>
/// ApiResponseHelper
/// </summary>
public static class ApiResponseHelper
{
    /// <summary>
    /// ExecuteAsync for single instance
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="action"></param>
    /// <param name="logger"></param>
    /// <returns></returns>
    public static async Task<IActionResult> ExecuteAsync<T>(Func<Task<BaseResponse<T>>> action, ILogger logger)
    {
        try
        {
            var result = await action();
            if (result.IsSuccessful)
            {
                if (result.Data == null)
                    return new NoContentResult();

                return new OkObjectResult(result.Data);
            }
            else
            {
                logger.LogInformation(result.Error);
                return new BadRequestObjectResult(result.Error);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Exception On API Call");
            return new StatusCodeResult(500);
        }
    }
    /// <summary>
    /// ExecuteAsync for Collections
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="action"></param>
    /// <param name="logger"></param>
    /// <returns></returns>
    public static async Task<IActionResult> ExecuteAsync<T>(Func<Task<BaseResponseCollection<T>>> action, ILogger logger)
    {
        try
        {
            var result = await action();
            if (result.IsSuccessful)
            {
                if (result.Data == null)
                    return new NoContentResult();

                return new OkObjectResult(result.Data);
            }
            else
            {
                logger.LogInformation(result.Error);
                return new BadRequestObjectResult(result.Error);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Exception On API Call");
            return new StatusCodeResult(500);
        }
    }
}
