using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreFrame.WebApi.Dto;
using NetCoreFrame.WebApi.Service;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFrame.WebApi.Controllers
{

    /// <summary>
    ///  DataController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
   
    public class DataController : ControllerBase
    {
        private readonly Water_GasService _water_GasService;
        private readonly Water_QualityService _water_QualityService;
        public DataController(Water_GasService water_GasService, Water_QualityService water_QualityService)
        {
            _water_GasService = water_GasService;
            _water_QualityService = water_QualityService;
        }

        [HttpGet("five")]
        public async Task<DataResponse> GetCurrentData(string VariableName, bool IsGas)
        {
            DataResponse dataResponse = new DataResponse();
            List<MyTableData> currentList = new List<MyTableData>();
            //水质
            var qualitylist = _water_QualityService.AsQueryable().OrderBy(s => s.CreateTime, SqlSugar.OrderByType.Desc).Take(6).ToList();

            //气体
            var gaslist = _water_GasService.AsQueryable().OrderBy(s => s.CreateTime, SqlSugar.OrderByType.Desc).Take(6).ToList();

             
            #region 变量
            VariableNames variableNames = new VariableNames();
            variableNames.TOC = qualitylist.First()?.TOC.ToString("0.000") ?? "0.000";
            variableNames.AD = qualitylist.First()?.AD.ToString("0.000") ?? "0.000";
            variableNames.ZL = qualitylist.First()?.ZL.ToString("0.000") ?? "0.000";
            variableNames.PH = qualitylist.First()?.PH.ToString("0.000") ?? "0.000";
            variableNames.LL = qualitylist.First()?.LL.ToString("0.000") ?? "0.000";

            variableNames.H2S = gaslist.First()?.H2S.ToString("0.000") ?? "0.000";
            variableNames.HCL = gaslist.First()?.HCL.ToString("0.000") ?? "0.000";
            variableNames.CL2 = gaslist.First()?.CL2.ToString("0.000") ?? "0.000";
            variableNames.NH3 = gaslist.First()?.NH3.ToString("0.000") ?? "0.000";
            dataResponse.variableNames = variableNames;
            #endregion

            #region 折线图
            ChartData chartData = new ChartData();
            if (IsGas)
            {
                chartData.categories = gaslist.OrderBy(s => s.CreateTime).Select(s => s.CreateTime.ToString("HH:mm")).ToList();
                Series series = new Series();
                series.name = VariableName;
                switch (VariableName)
                {
                    case "H2S":
                        series.data = gaslist.ToList().Select(s => s.H2S.ToString("0.000")).ToList();
                        currentList = gaslist.ToList().Select(s => new MyTableData()
                        {
                            CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                            CurrentData = s.H2S.ToString("0.000"),
                            IsCorrect= s.H2S<Convert.ToDecimal("0.06")?true:false

                        }).ToList();
                        break;
                    case "HCL":
                        series.data = gaslist.ToList().Select(s => s.HCL.ToString("0.000")).ToList();
                        currentList = gaslist.ToList().Select(s => new MyTableData()
                        {
                            CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                            CurrentData = s.HCL.ToString("0.000"),
                            IsCorrect = s.HCL < Convert.ToDecimal("0.15") ? true : false

                        }).ToList();
                        break;
                    case "CL2":
                        series.data = gaslist.ToList().Select(s => s.CL2.ToString("0.000")).ToList();
                        currentList = gaslist.ToList().Select(s => new MyTableData()
                        {
                            CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                            CurrentData = s.CL2.ToString("0.000"),
                            IsCorrect = s.CL2 < Convert.ToDecimal("0.5") ? true : false

                        }).ToList();
                        break;
                    case "NH3":
                        series.data = gaslist.ToList().Select(s => s.NH3.ToString("0.000")).ToList();
                        currentList = gaslist.ToList().Select(s => new MyTableData()
                        {
                            CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                            CurrentData = s.NH3.ToString("0.000"),
                            IsCorrect = s.NH3 < Convert.ToDecimal("1.0") ? true : false

                        }).ToList();
                        break;
                    default:
                        break;
                }
                chartData.series.Add(series);
            }
            else
            {
                
                    chartData.categories = qualitylist.OrderBy(s => s.CreateTime).Select(s => s.CreateTime.ToString("HH:mm")).ToList();
                    Series series = new Series();
                    series.name = VariableName;
                    switch (VariableName)
                    {
                        case "TOC":
                      
                            series.data = qualitylist.ToList().Select(s => s.TOC.ToString("0.000")).ToList();
                            currentList = qualitylist.ToList().Select(s => new MyTableData()
                            {
                                CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                                CurrentData = s.TOC.ToString("0.000"),
                                IsCorrect = s.TOC < Convert.ToDecimal("50") ? true : false

                            }).ToList();
                            break;
                        case "AD":
                            series.data = qualitylist.ToList().Select(s => s.AD.ToString("0.000")).ToList();
                            currentList = qualitylist.ToList().Select(s => new MyTableData()
                            {
                                CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                                CurrentData = s.AD.ToString("0.000"),
                                IsCorrect = s.AD < Convert.ToDecimal("5") ? true : false

                            }).ToList();
                            break;
                        case "PH":
                            series.data = qualitylist.ToList().Select(s => s.PH.ToString("0.000")).ToList();
                            currentList = qualitylist.ToList().Select(s => new MyTableData()
                            {
                                CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                                CurrentData = s.PH.ToString("0.000"),
                                IsCorrect = (s.PH < Convert.ToDecimal("6") || s.PH > Convert.ToDecimal("9"))?false:true 
                            }).ToList();
                            break;
                        case "ZL":
                            series.data = qualitylist.ToList().Select(s => s.ZL.ToString("0.000")).ToList(); 
                            currentList = qualitylist.ToList().Select(s => new MyTableData()
                            {
                                CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                                CurrentData = s.ZL.ToString("0.000"),
                                IsCorrect = s.ZL < Convert.ToDecimal("0.5") ? true : false

                            }).ToList();
                            break;
                        case "LL":
                            series.data = qualitylist.ToList().Select(s => s.LL.ToString("0.000")).ToList();
                            currentList = qualitylist.ToList().Select(s => new MyTableData()
                            {
                                CreateTime = s.CreateTime.ToString("yyyy-MM-dd HH:mm"),
                                CurrentData = s.LL.ToString("0.000"),
                                IsCorrect = true 
                            }).ToList();
                            break;
                        default:
                            break;
                    }
                    chartData.series.Add(series);

            }
            dataResponse.chartData=chartData;
            #endregion

            #region 列表

            dataResponse.myTableDatas = currentList;
            #endregion

            return dataResponse;
        }
    }
}
