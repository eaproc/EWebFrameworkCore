﻿using ELibrary.Standard.VB.Objects;
using NPOI.SS.UserModel;

namespace EWebFrameworkCore.Vendor.Utils.DataExports.Excel
{
    public static class NPOIGridExportGenericExtensions
    {

        public static ICell SetCellValueX(this IRow row, int ColumnZeroIndex, object? value, string? DataFormat = null)
        {

            ICell cell = row.GetOrCreate(ColumnZeroIndex);


            if (value != null && value.GetType() == typeof(string))
                cell.SetCellValue(EStrings.ValueOf(value));

            else if (value != null && value.GetType() == typeof(DateTime))
                cell.SetCellValue((DateTime)value);

            else if (value != null && value.GetType() == typeof(string))
                cell.SetCellValue((string)value);

            else if (value != null && value.GetType() == typeof(bool))
                cell.SetCellValue((bool)value);

            else cell.SetCellValue(EDouble.ValueOf(value));


            if (DataFormat != null)
            {
                ICellStyle p = cell.Sheet.Workbook.CreateCellStyle();
                cell.CellStyle.DataFormat = cell.Sheet.Workbook.CreateDataFormat().GetFormat(DataFormat);
            }

            return cell;
        }


        public static ISheet AutoSizeColumns(this ISheet sheet, int StartColumnZeroIndex = 0, int EndColumnZeroIndex = 4)
        {
            for (int i = StartColumnZeroIndex; i <= EndColumnZeroIndex; i++)
            {
                sheet.AutoSizeColumn(i);
            }  
            return sheet;
        }


        public static RT? GetValue<TO, RT>(this TO obj, string propName) where TO : class
        {
            // not found
            if (obj == null) return default;

            if (obj.GetType().GetProperties().Where(x => x.Name == propName).Count() == 1)
                return (RT?)obj.GetType().GetProperty(propName)?.GetValue(obj, null);

            if (obj.GetType().GetFields().Where(x => x.Name == propName).Count() == 1)
                return (RT?)obj.GetType().GetField(propName)?.GetValue(obj);

            return default(RT);
        }

    }
}