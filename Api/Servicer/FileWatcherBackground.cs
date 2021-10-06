using Microsoft.Extensions.Hosting;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Servicer
{
    public class FileWatcherBackground : BackgroundService
    {
        private readonly IHostEnvironment _env;
        private FileSystemWatcher _fsw;
        public FileWatcherBackground(IHostEnvironment env)
        {
            _env = env;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            return base.StartAsync(cancellationToken);
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            string path = Path.Combine(_env.ContentRootPath, "wwwroot");
            _fsw = new FileSystemWatcher(path, "*.xlsx");
            _fsw.Created += fsw_Created;
            _fsw.Changed += fsw_Changed;
            _fsw.Renamed += fsw_Renamed;
            _fsw.Deleted += fsw_Deleted;
            _fsw.Error += fsw_Error;
            _fsw.EnableRaisingEvents = true;
            

            return Task.CompletedTask;
        }

        private void fsw_Changed(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine("Archivo modificado de excel");
        }

        private void fsw_Deleted(object sender,FileSystemEventArgs e)
        {
            Console.WriteLine("Borrar archivo");
        }
        private void fsw_Created(object sender,FileSystemEventArgs e)
        {
            Console.WriteLine("Coger el archivo nuevo creado y importarlo con una libreria a un list y procesarlo para actualizacion");
            Task.Delay(5000).Wait();
            LeerArchivo(e.FullPath);
        }
     
        private void fsw_Error(object sender,ErrorEventArgs e)
        {
            Console.WriteLine("Problemas y errores con el archivo");
        }
        private void fsw_Renamed(object sender,FileSystemEventArgs e)
        {
            Console.WriteLine("archivo renombrado");
        }
        private void LeerArchivo(string path)
        {
            ISheet sheet;
            List<string> rowList = new List<string>();

            using (var stream = new FileStream(path,FileMode.Open))
            {
                stream.Position = 0;
                XSSFWorkbook xssWorkbook = new XSSFWorkbook(stream);
                sheet = xssWorkbook.GetSheetAt(0);
                IRow headerRow = sheet.GetRow(0);
                int cellCount = headerRow.LastCellNum;

                for (int i = (sheet.FirstRowNum +1); i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null) continue;
                    if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;

                    for (int j = row.FirstCellNum;j<cellCount; j++)
                    {
                        if (row.GetCell(j) != null)
                        {
                            if (!string.IsNullOrEmpty(row.GetCell(j).ToString()))
                            {
                                rowList.Add(row.GetCell(j).ToString());

                            }
                        }
                    }
                }
                int count = rowList.Count();



            }


        }
    }
}
