using System;
using System.Collections.Generic;
namespace HotelReservationWebsiteAPI.DTOs
{
    public class PromotionDTO
    {
        public int PromotionID { get; set; }
        public string PromotionCode { get; set; }
        public DateTime PromotionStartTime { get; set; }
        public DateTime PromotionFinishTime { get; set; }
        public string FormOfPromotion { get; set; }
        public int PromotionStatus { get; set; }
    }

}