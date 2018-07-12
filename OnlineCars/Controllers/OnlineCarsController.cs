using OnlineCars.Data.Models;
using OnlineCars.Models;
using OnlineCars.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineCars.Controllers
{
    public class OnlineCarsController : ApiController
    {
        IService _service = new Service();
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                List<Car> _res = _service.GetAllCars();
                CarViewModel _viewModel;
                AdditionalInfoViewModel _addinfo;
                List<CarViewModel> _result = new List<CarViewModel>();
                foreach (var item in _res)
                {
                    _addinfo = new AdditionalInfoViewModel() { AdditionalInfoID = item.AdditionalInfoID, bids = item.AdditionalInfo.bids,
                        currencyAr = item.AdditionalInfo.currencyAr, currencyEn = item.AdditionalInfo.currencyEn, currentPrice = item.AdditionalInfo.currentPrice,
                        endDate = item.AdditionalInfo.endDate, endDateAr = item.AdditionalInfo.endDateAr, endDateEn = item.AdditionalInfo.endDateEn,
                        iCarId = item.AdditionalInfo.iCarId, isModified = item.AdditionalInfo.isModified, itemid = item.AdditionalInfo.itemid, iVinNumber = item.AdditionalInfo.iVinNumber,
                        lot = item.AdditionalInfo.lot, minIncrement = item.AdditionalInfo.minIncrement, priority = item.AdditionalInfo.priority, VATPercent = item.AdditionalInfo.VATPercent };
                    _viewModel = new CarViewModel()
                    {
                        bodyAr = item.Body.bodyAr,
                        bodyEn = item.Body.bodyEn,
                        bodyId = item.bodyId,
                        CarID = item.CarID,
                        Description_Ar = item.Description_Ar,
                        Description_En = item.Description_En,
                        Image = item.Image,
                        imgCount = item.imgCount,
                        makeAr = item.Make.makeAr,
                        makeEn = item.Make.makeEn,
                        makeID = item.makeID,
                        mileage = item.mileage,
                        modelAr = item.Model.modelAr,
                        modelID = item.modelID,
                        modelEn = item.Model.modelEn,
                        SharingLink = item.SharingLink,
                        year = item.year,
                        AdditionalInfo = _addinfo
                    };

                    _viewModel.SharingMsgAR = item.AuctionCompany.CompanyNameAr + "\n" + item.Make.makeAr + "-" + item.Model.modelAr + item.year + "\n" +
                        item.AdditionalInfo.lot + "\n" + item.AdditionalInfo.currentPrice +item.AdditionalInfo.currencyAr +"\n" +item.AdditionalInfo.endDateAr;

                    _viewModel.SharingMsgEn = item.AuctionCompany.CompanyNameEn + "\n" + item.Make.makeEn + "-" + item.Model.modelEn + item.year + "\n" +
                     item.AdditionalInfo.lot + "\n" + item.AdditionalInfo.currentPrice + item.AdditionalInfo.currencyEn + "\n" + item.AdditionalInfo.endDateEn;



                    _result.Add(_viewModel);

                }

                return Ok(_result);
            }
            catch (Exception EX)
            {
                return InternalServerError();
            }
        }
        [HttpGet]
        public IHttpActionResult GetSome(int PageNumber)
        {
            
            try
            {
                List<Car> _res = _service.GetMoreItems(PageNumber);
                CarViewModel _viewModel;
                AdditionalInfoViewModel _addinfo;
                List<CarViewModel> _result = new List<CarViewModel>();
                foreach (var item in _res)
                {
                    _addinfo = new AdditionalInfoViewModel()
                    {
                        AdditionalInfoID = item.AdditionalInfoID,
                        bids = item.AdditionalInfo.bids,
                        currencyAr = item.AdditionalInfo.currencyAr,
                        currencyEn = item.AdditionalInfo.currencyEn,
                        currentPrice = item.AdditionalInfo.currentPrice,
                        endDate = item.AdditionalInfo.endDate,
                        endDateAr = item.AdditionalInfo.endDateAr,
                        endDateEn = item.AdditionalInfo.endDateEn,
                        iCarId = item.AdditionalInfo.iCarId,
                        isModified = item.AdditionalInfo.isModified,
                        itemid = item.AdditionalInfo.itemid,
                        iVinNumber = item.AdditionalInfo.iVinNumber,
                        lot = item.AdditionalInfo.lot,
                        minIncrement = item.AdditionalInfo.minIncrement,
                        priority = item.AdditionalInfo.priority,
                        VATPercent = item.AdditionalInfo.VATPercent
                    };
                    _viewModel = new CarViewModel()
                    {
                        bodyAr = item.Body.bodyAr,
                        bodyEn = item.Body.bodyEn,
                        bodyId = item.bodyId,
                        CarID = item.CarID,
                        Description_Ar = item.Description_Ar,
                        Description_En = item.Description_En,
                        Image = item.Image,
                        imgCount = item.imgCount,
                        makeAr = item.Make.makeAr,
                        makeEn = item.Make.makeEn,
                        makeID = item.makeID,
                        mileage = item.mileage,
                        modelAr = item.Model.modelAr,
                        modelID = item.modelID,
                        modelEn = item.Model.modelEn,
                        SharingLink = item.SharingLink,
                        year = item.year,
                        AdditionalInfo = _addinfo
                    };

                    _viewModel.SharingMsgAR = item.AuctionCompany.CompanyNameAr + "\n" + item.Make.makeAr + "-" + item.Model.modelAr + item.year + "\n" +
                        item.AdditionalInfo.lot + "\n" + item.AdditionalInfo.currentPrice + item.AdditionalInfo.currencyAr + "\n" + item.AdditionalInfo.endDateAr;

                    _viewModel.SharingMsgEn = item.AuctionCompany.CompanyNameEn + "\n" + item.Make.makeEn + "-" + item.Model.modelEn + item.year + "\n" +
                     item.AdditionalInfo.lot + "\n" + item.AdditionalInfo.currentPrice + item.AdditionalInfo.currencyEn + "\n" + item.AdditionalInfo.endDateEn;



                    _result.Add(_viewModel);

                }

                return Ok(_result);
            }
            catch (Exception EX)
            {
                return InternalServerError();
            }
        }
    }
}
