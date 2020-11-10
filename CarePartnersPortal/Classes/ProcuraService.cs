using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace CarePartnersPortal
{
    public class ProcuraService
    {
        DBContextProcura db;
        public List<ProcuraFile> UploadFileData(string filePath)
        {

            FileInfo fileInfo = new FileInfo(filePath);
            List<ProcuraFile> procuraFiles = new List<ProcuraFile>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault();
                int totalCollumn = worksheet.Dimension.End.Column;
                int totalRow = worksheet.Dimension.End.Row;

                for (int row = 2; row < totalRow; row++)
                {
                    ProcuraFile file = new ProcuraFile();
                    
                    file.Source_DB_Name = worksheet.Cells[row, 1].Value.ToString();
                    file.client_number = Convert.ToUInt64(worksheet.Cells[row, 2].Value.ToString());
                    file.File_Name = worksheet.Cells[row, 3].Value.ToString();
                    file.File_Type = worksheet.Cells[row, 5].Value.ToString();
                    file.DEF_SUBJECT = worksheet.Cells[row, 6].Value.ToString();
                    file.File_Path = worksheet.Cells[row, 7].Value.ToString();                    

                    procuraFiles.Add(file);

                }
            }
            return procuraFiles;
        }
        public void ZipFiles(string path, string file)
        {
            var zipFile = @"C:\temp\" + file + ".zip";
            if (File.Exists(Path.Combine(zipFile)))
            {                 
                File.Delete(Path.Combine(zipFile));
            }

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                
            }
            using (FileStream zipToOpen = new FileStream(zipFile, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.CreateEntryFromFile(path + "\\" + file,file);    
                }
            }



        }
        public void Unzip(string path, string file)
        {
            string zipPath = @"C:\temp\"+ file;
            string extractPath = path + "\\" + file;
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        public byte[] GetByteArray(string path, string file)
        {
            byte[] retVal = null;
            var zipFile = @"C:\temp\" + file + ".zip";
            //using (var compressedFileStream = new MemoryStream())
            //{
            //    //Create an archive and store the stream in memory.
            //    using (var zipArchive = new ZipArchive(compressedFileStream, ZipArchiveMode.Create, false))
            //    {
            //        //Create a zip entry for each attachment
            //        var zipEntry = zipArchive.CreateEntry(path+ "\\"+ file);
            //        return compressedFileStream.ToArray();
            //    }
            //}

            if (File.Exists(Path.Combine(@"C:\temp\", file + ".zip")))
            {
                File.Delete(Path.Combine(@"C:\temp\", file + ".zip"));
            }
            if (File.Exists(Path.Combine(path + "\\" + file)))
            {
                using (MemoryStream zipStream = new MemoryStream())
                {
                    using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Create, true))
                    {
                        var entry = archive.CreateEntryFromFile(path + "\\" + file, file);
                    }
                    retVal = null;
                    retVal = zipStream.ToArray();
                }
                return retVal;
            }
            else
            {
                return retVal;
            }
        }

        public List<ProcuraFile> ProcessFiles(List<ProcuraFile> files)
        {
            foreach (ProcuraFile file in files)
            {

                var zipFile = @"C:\temp\" + file.File_Name + ".zip";
                string filepath = file.File_Path + "\\" + file.File_Name;
                if (File.Exists(zipFile));
                {
                    File.Delete(zipFile);
                }
                if (File.Exists(Path.Combine(filepath)))
                {
                    using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
                    {
                    }
                    using (FileStream zipToOpen = new FileStream(zipFile, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.CreateEntryFromFile(filepath, file.File_Name);
                        }
                    }

                    FileInfo fileInfo = new FileInfo(filepath);
                    FileInfo zipInfo = new FileInfo(zipFile);

                    file.File_Size = fileInfo.Length;
                    file.File_Date = fileInfo.CreationTime;
                    file.ZIP_File_Size = zipInfo.Length;
                    file.ZIP_File_Image = File.ReadAllBytes(zipFile);
                }
            }
            return files;
        }
    }

}
