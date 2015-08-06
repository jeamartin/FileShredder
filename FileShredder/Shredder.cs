using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileShredder
{
    class Shredder
    {
        protected string sourceFile;
        protected string targetFolder;
        protected byte numberOfPart = 2;
        protected long sourceLength;

        protected const byte lessSigMask = 0x01;

        public string SourceFile
        {
            get { return sourceFile; }
            set { sourceFile = value; }
        }
        
        public string TargetFolder
        {
            get { return targetFolder; }
            set { targetFolder = value; }
        }

        public void ShredFile()
        {
            FileInfo fi = new FileInfo(sourceFile);
            sourceLength = fi.Length; 
            
            using(FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read)) {
                byte[] curRead = new byte[1024];

                FileStream[] fsWrite = new FileStream[numberOfPart];

                for (byte i = 0; i < numberOfPart; i++)
                {
                    fsWrite[i] = new FileStream(partFileName(i), FileMode.Create, FileAccess.Write);
                    fsWrite[i].Write(getHeader(i), 0, 10);
                }
                try
                {
                    int qtyRead = 0;
                    long cursor = 0 ;
                    byte[] curWrite = new byte[numberOfPart];
                    byte[] curWriteIndex = new byte[numberOfPart];
                    initByteArray(ref curWrite);
                    initByteArray(ref curWriteIndex);

                    while ((qtyRead = fsRead.Read(curRead, 0, 1024)) > 0)
                        for (int i = 0; i < qtyRead; i++)
                        {
                            byte cur = curRead[i];
                            for(byte j = 0; j < 8; j++)
                            {
                                byte part = (byte)(cursor % numberOfPart);
                                //1 copier le bit plus a droite dans curWrite part
                                if ((cur & lessSigMask) > 0)
                                    curWrite[part] += (byte)Math.Pow(2, curWriteIndex[part]);
                                //2incrémenter la partie a écrire
                                curWriteIndex[part]++;
                                //3 décaler le byte cur en fonction
                                cur = (byte)(cur >> 1);

                                //4 si curwriteindex == 8 alors écrire curWrite[part] dans fsWrite[part]
                                if (curWriteIndex[part] == 8)
                                {
                                    fsWrite[part].Write(curWrite[part].ToArray(), 0, 1);
                                    //puis réinitialiser curwrite[part] et curWriteIndexDePart
                                    curWrite[part] = 0;
                                    curWriteIndex[part] = 0;
                                }
                                cursor++;
                            }
                        }
                    //5 écrire le reste de curWrite dans fsWrite 
                }
                finally
                {
                    for (byte i = 0; i < numberOfPart; i++)
                        fsWrite[i].Close(); 
                }

            }
        }

        protected void initByteArray(ref byte[]toInit) {
            for (int i = 0; i < toInit.Length; i++)
                toInit[i] = 0; 
        }

        protected byte[] getHeader(byte index)
        {
            byte[] length = BitConverter.GetBytes(sourceLength);

            byte[] ret = new byte[10];

            length.CopyTo(ret, 0);
            ret[8] = index ;
            ret[9] = numberOfPart;
            return ret; 
        }

        protected string partFileName(byte index)
        {
            string ret = 
                Path.GetPathRoot(targetFolder) + Path.GetDirectoryName(targetFolder) + Path.DirectorySeparatorChar 
                + Path.GetFileName(sourceFile) + ".shrd" + index.ToString().PadLeft(3, '0');
            return ret; 
        }

    }
}
