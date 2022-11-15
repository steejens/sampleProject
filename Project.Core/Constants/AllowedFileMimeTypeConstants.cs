namespace Project.Core.Constants
{
    public static class AllowedFileMimeTypeConstants
    {
        public static string[] MimeTypes = new string[]
        {
            "application/pdf",
            "application/msword",
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            "application/vnd.ms-excel",
            "application/vnd.ms-powerpoint",
            "application/vnd.openxmlformats-officedocument.presentationml.presentation",
            "video/mp4",
            "application/mp4",
            "audio/mpeg"

        };
    }

    public static class AllowedFileExtension
    {
        public static string[] Extensions = new string[]
        {
            ".pdf",
            ".doc",
            ".docx",
            ".xlsx",
            ".xls",
            ".ppt",
            ".pptx",
            ".mp4",
            ".mp3",
            ".png",
            ".jpg",
            ".jpeg",
            ".svg"
        };
    }

    public static class AllowedFileSignature
    {
        // For more file signatures, see the File Signatures Database (https://www.filesignatures.net/)
        // and the official specifications for the file types you wish to add.
        public static readonly Dictionary<string, List<byte[]>> FileSignature = new Dictionary<string, List<byte[]>>
        {
            //{ ".gif", new List<byte[]> { new byte[] { 0x47, 0x49, 0x46, 0x38 } } },
            //{ ".png", new List<byte[]> { new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A } } },
            //{ ".jpeg", new List<byte[]>
            //    {
            //        new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 },
            //        new byte[] { 0xFF, 0xD8, 0xFF, 0xE2 },
            //        new byte[] { 0xFF, 0xD8, 0xFF, 0xE3 },
            //    }
            //},
            //{ ".jpg", new List<byte[]>
            //    {
            //        new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 },
            //        new byte[] { 0xFF, 0xD8, 0xFF, 0xE1 },
            //        new byte[] { 0xFF, 0xD8, 0xFF, 0xE8 },
            //    }
            //},
            //{ ".zip", new List<byte[]>
            //    {
            //        new byte[] { 0x50, 0x4B, 0x03, 0x04 },
            //        new byte[] { 0x50, 0x4B, 0x4C, 0x49, 0x54, 0x45 },
            //        new byte[] { 0x50, 0x4B, 0x53, 0x70, 0x58 },
            //        new byte[] { 0x50, 0x4B, 0x05, 0x06 },
            //        new byte[] { 0x50, 0x4B, 0x07, 0x08 },
            //        new byte[] { 0x57, 0x69, 0x6E, 0x5A, 0x69, 0x70 },
            //    }
            //},
            {".pdf",new List<byte[]>
            {
                new byte[]{ 0x25, 0x50, 0x44, 0x46,0x0F }
            }}
            ,
            {".doc",new List<byte[]>
            {
                new byte[]{0xEC,0xA5,0xC1,0x00}
            }},
            {".docx",new List<byte[]>
            {
                new byte[]{ 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }
            }},
            {".xls",new List<byte[]>
            {
                new byte[]{0x09,0x08,0x10,0x00,0x00,0x06,0x50,0x00}
            }},

            {".xlsx",new List<byte[]>
            {
                new byte[]{ 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }
            }},

            {".ppt",new List<byte[]>
            {
                new byte[]{ 0x00 ,0x6E ,0x1E ,0xF0}
            }},

            {".pptx",new List<byte[]>
            {
                new byte[]{ 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }
            }},
            {".mp4",new List<byte[]>
            {
                //new byte[]{ 0x66 ,0x74, 0x79, 0x70, 0x4D, 0x53, 0x4E, 0x56 },
                //new byte[]{ 0x66 ,0x74, 0x79, 0x70, 0x69 ,0x73 ,0x6F,0x6D },
                //new byte[]{ 0x00,0x00, 0x01,0xB3},
                new byte[]{ 0x00, 0x00, 0x01, 0xB7 },
                //new byte[]{ 0x00, 0x00, 0x01, 0xB9 }

            }},
        };
    }
}
