﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    class CopyBinaryFile
    {

        static void Main()
        {
            string ImagePath = "../../image.jpg";
            string DestinationPath = "../../result.txt";
            using (var source = new FileStream(ImagePath, FileMode.Open))
            {
                using (var destination = new FileStream(DestinationPath, FileMode.Create))
                {
                    byte[] buffer = new byte[source.Length];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
