using ELibrary.Standard.VB.Objects;
using EWebFrameworkCore.Vendor.Services;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;

namespace EWebFrameworkCore.Vendor.Utils.DataExports.Excel
{
    public abstract class IEPPlusExcelExportCustomizer: INPOIExcelExport
    {

        //Indicate where data rows should begin writing
        protected abstract int StartAtIndex { get; }

        protected abstract string TemplateFileFullPath { get;  }

        public IEPPlusExcelExportCustomizer(DataTable dataTable) : base(data: dataTable) { }


        public abstract void DoSomeCustomization(ISheet sheet1);


        public virtual void SetCellValue(ICell cell, ushort columnIndex,  object v)
        {
            // Default just sets it as string
            cell.SetCellValue(EStrings.ValueOf(v));
        }


        public bool ExportListUsingNPOI(out string pFilePath)
        {
            
            using TemporaryFile returnResultFile = new ();
            returnResultFile.CreatePath().SetLeaveAsUndisposed(true);
            pFilePath = returnResultFile.FileFullPath;

            if (!File.Exists(TemplateFileFullPath)) throw new FileNotFoundException("Template File Does not Exists - " + this.TemplateFileFullPath);

            using TemporaryFile tmpFile = new();
            //Take a copy of the Template FIle
            File.Copy(this.TemplateFileFullPath, tmpFile.FileFullPath, true);


            IWorkbook workbook;
            // Use it for generating the file
            workbook = new XSSFWorkbook(tmpFile.FileFullPath);


            int currentRowIndex = this.StartAtIndex; // currentRowIndex

            ISheet sheet1 = workbook.GetSheetAt(0); //First Sheet


            //If you need to work on the sheet
            this.DoSomeCustomization(sheet1);


            //loops through data
            foreach (var r in this.GetData())
            {
                IRow row = sheet1.CreateRow(currentRowIndex);
                for (int j = 0; j < r.Count; j++)
                {

                    ICell cell = row.CreateCell(j);
                    this.SetCellValue(cell, (ushort)j, r.ElementAt(j).Value);
                }


                currentRowIndex++;

            }


            //It doesn't write if you don't call this
            // #BUG
            using (var fs = new FileStream(returnResultFile.FileFullPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                workbook.Write(fs, false);
            }

            workbook.Close();

            return File.Exists(returnResultFile.FileFullPath);

        }

    }
}
