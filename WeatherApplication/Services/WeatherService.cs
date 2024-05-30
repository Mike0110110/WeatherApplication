using Flurl.Http;
using WeatherApplication.Models;

namespace WeatherApplication.Services
{
    public class WeatherService
    {
        public async Task<ResponseModel> GetWeatherData(string location)
        {

            string weatherApiUrl = AppConstant.WeatherApiUrl;
            string weatherApiKey = AppConstant.WeatherApiKey;
            string apiUrl = $"{weatherApiUrl}?key={weatherApiKey}&q={location}";


            try
            {
                var response = await apiUrl.GetAsync();
                if (response.StatusCode == 200)
                {
                    var responseData = await response.GetJsonAsync<WeatherModel>();
                    return ResponseModel.Success(responseData);
                }
                return ResponseModel.Error(response.ResponseMessage.ToString());
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseStringAsync();
                return ResponseModel.Error(errorResponse);
            }

        }
    }
}
