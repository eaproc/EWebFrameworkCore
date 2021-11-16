using EWebFrameworkCore.Vendor.Services.DataTablesNET;

namespace EWebFrameworkCore.Vendor.JsonReplies
{
    public class DataTableSuccessMessage:SuccessResult
    {

        public DataTableSuccessMessage(DataTableReturnFormat pData):base(pData:pData.data)
        {
            this.draw = pData.draw;
            this.recordsFiltered = pData.recordsFiltered;
            this.recordsTotal = pData.recordsTotal;
            this.totalPagesSummary = pData.totalPagesSummary;
        }

        
        public int draw, recordsTotal, recordsFiltered;
        public object totalPagesSummary;


    }
}