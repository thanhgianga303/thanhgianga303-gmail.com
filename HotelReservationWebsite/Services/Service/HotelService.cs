using System.Collections.Generic;
using System.Threading.Tasks;
using HotelReservationWebsite.Models;
using HotelReservationWebsite.Services.IService;

namespace HotelReservationWebsite.Services.Service
{
    public class HotelService : IHotelService
    {
        private readonly CustomHttpClient _httpClient;
        private readonly string _baseUrl;
        public HotelService(CustomHttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUrl = "http://localhost:5001/api/hotel";
        }
        public async Task<IEnumerable<Hotel>> GetHotels(string searchString)
        {
            var url = _baseUrl + $"?{searchString}";
            return await _httpClient.GetListAsync<Hotel>(url);
        }
        public async Task<Hotel> GetHotel(int id)
        {
            var url = _baseUrl + $"/{id}";
            return await _httpClient.GetAsync<Hotel>(url);
        }
        public async Task CreateHotel(Hotel hotel)
        {
            var url = _baseUrl;
            await _httpClient.PostAsync(url, hotel);
        }
        public async Task UpdateHotel(int id, Hotel hotel)
        {
            var url = _baseUrl + $"{id}";
            await _httpClient.PutAsync(url, hotel);
        }
        public async Task DeleteHotel(int id)
        {
            var url = _baseUrl + $"{id}";
            await _httpClient.DeleteAsync(url);
        }
    }
}