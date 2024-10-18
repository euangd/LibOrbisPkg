﻿namespace LibOrbisPkg.Util
{
    /// <summary>
    /// Contains keys in big-endian format
    /// </summary>
    public class RSAKeyset
    {
        // d
        public byte[] PrivateExponent;
        // exponent1 = d mod (p - 1)
        public byte[] Exponent1;
        // exponent2 = d mod (q - 1)
        public byte[] Exponent2;
        // e
        public byte[] PublicExponent;
        // (InverseQ)(q) = 1 mod p
        public byte[] Coefficient;
        // n = p * q
        public byte[] Modulus;
        // p
        public byte[] Prime1;
        // q
        public byte[] Prime2;

        /// <summary>
        /// Used to encrypt the IMAGE_KEY entry
        /// </summary>
        public static RSAKeyset FakeKeyset = new RSAKeyset
        {
            PrivateExponent = new byte[0x100]
          {
        0x7F, 0x76, 0xCD, 0x0E, 0xE2, 0xD4, 0xDE, 0x05, 0x1C, 0xC6, 0xD9, 0xA8, 0x0E, 0x8D, 0xFA, 0x7B,
        0xCA, 0x1E, 0xAA, 0x27, 0x1A, 0x40, 0xF8, 0xF1, 0x22, 0x87, 0x35, 0xDD, 0xDB, 0xFD, 0xEE, 0xF8,
        0xC2, 0xBC, 0xBD, 0x01, 0xFB, 0x8B, 0xE2, 0x3E, 0x63, 0xB2, 0xB1, 0x22, 0x5C, 0x56, 0x49, 0x6E,
        0x11, 0xBE, 0x07, 0x44, 0x0B, 0x9A, 0x26, 0x66, 0xD1, 0x49, 0x2C, 0x8F, 0xD3, 0x1B, 0xCF, 0xA4,
        0xA1, 0xB8, 0xD1, 0xFB, 0xA4, 0x9E, 0xD2, 0x21, 0x28, 0x83, 0x09, 0x8A, 0xF6, 0xA0, 0x0B, 0xA3,
        0xD6, 0x0F, 0x9B, 0x63, 0x68, 0xCC, 0xBC, 0x0C, 0x4E, 0x14, 0x5B, 0x27, 0xA4, 0xA9, 0xF4, 0x2B,
        0xB9, 0xB8, 0x7B, 0xC0, 0xE6, 0x51, 0xAD, 0x1D, 0x77, 0xD4, 0x6B, 0xB9, 0xCE, 0x20, 0xD1, 0x26,
        0x66, 0x7E, 0x5E, 0x9E, 0xA2, 0xE9, 0x6B, 0x90, 0xF3, 0x73, 0xB8, 0x52, 0x8F, 0x44, 0x11, 0x03,
        0x0C, 0x13, 0x97, 0x39, 0x3D, 0x13, 0x22, 0x58, 0xD5, 0x43, 0x82, 0x49, 0xDA, 0x6E, 0x7C, 0xA1,
        0xC5, 0x8C, 0xA5, 0xB0, 0x09, 0xE0, 0xCE, 0x3D, 0xDF, 0xF4, 0x9D, 0x3C, 0x97, 0x15, 0xE2, 0x6A,
        0xC7, 0x2B, 0x3C, 0x50, 0x93, 0x23, 0xDB, 0xBA, 0x4A, 0x22, 0x66, 0x44, 0xAC, 0x78, 0xBB, 0x0E,
        0x1A, 0x27, 0x43, 0xB5, 0x71, 0x67, 0xAF, 0xF4, 0xAB, 0x48, 0x46, 0x93, 0x73, 0xD0, 0x42, 0xAB,
        0x93, 0x63, 0xE5, 0x6C, 0x9A, 0xDE, 0x50, 0x24, 0xC0, 0x23, 0x7D, 0x99, 0x79, 0x3F, 0x22, 0x07,
        0xE0, 0xC1, 0x48, 0x56, 0x1B, 0xDF, 0x83, 0x09, 0x12, 0xB4, 0x2D, 0x45, 0x6B, 0xC9, 0xC0, 0x68,
        0x85, 0x99, 0x90, 0x79, 0x96, 0x1A, 0xD7, 0xF5, 0x4D, 0x1F, 0x37, 0x83, 0x40, 0x4A, 0xEC, 0x39,
        0x37, 0xA6, 0x80, 0x92, 0x7D, 0xC5, 0x80, 0xC7, 0xD6, 0x6F, 0xFE, 0x8A, 0x79, 0x89, 0xC6, 0xB1,
          },
            Exponent1 = new byte[0x80]
          {
        0x6D, 0x48, 0xE0, 0x54, 0x40, 0x25, 0xC8, 0x41, 0x29, 0x52, 0x42, 0x27, 0xEB, 0xD2, 0xC7, 0xAB,
        0x6B, 0x9C, 0x27, 0x0A, 0xB4, 0x1F, 0x94, 0x4E, 0xFA, 0x42, 0x1D, 0xB7, 0xBC, 0xB9, 0xAE, 0xBC,
        0x04, 0x6F, 0x75, 0x8F, 0x10, 0x5F, 0x89, 0xAC, 0xAB, 0x9C, 0xD2, 0xFA, 0xE6, 0xA4, 0x13, 0x83,
        0x68, 0xD4, 0x56, 0x38, 0xFE, 0xE5, 0x2B, 0x78, 0x44, 0x9C, 0x34, 0xE6, 0x5A, 0xA0, 0xBE, 0x05,
        0x70, 0xAD, 0x15, 0xC3, 0x2D, 0x31, 0xAC, 0x97, 0x5D, 0x88, 0xFC, 0xC1, 0x62, 0x3D, 0xE2, 0xED,
        0x11, 0xDB, 0xB6, 0x9E, 0xFC, 0x5A, 0x5A, 0x03, 0xF6, 0xCF, 0x08, 0xD4, 0x5D, 0x90, 0xC9, 0x2A,
        0xB9, 0x9B, 0xCF, 0xC8, 0x1A, 0x65, 0xF3, 0x5B, 0xE8, 0x7F, 0xCF, 0xA5, 0xA6, 0x4C, 0x5C, 0x2A,
        0x12, 0x0F, 0x92, 0xA5, 0xE3, 0xF0, 0x17, 0x1E, 0x9A, 0x97, 0x45, 0x86, 0xFD, 0xDB, 0x54, 0x25,
          },
            Exponent2 = new byte[0x80]
          {
        0x2A, 0x51, 0xCE, 0x02, 0x44, 0x28, 0x50, 0xE8, 0x30, 0x20, 0x7C, 0x9C, 0x55, 0xBF, 0x60, 0x39,
        0xBC, 0xD1, 0xF0, 0xE7, 0x68, 0xF8, 0x08, 0x5B, 0x61, 0x1F, 0xA7, 0xBF, 0xD0, 0xE8, 0x8B, 0xB5,
        0xB1, 0xD5, 0xD9, 0x16, 0xAC, 0x75, 0x0C, 0x6D, 0xF2, 0xE0, 0xB5, 0x97, 0x75, 0xD2, 0x68, 0x16,
        0x1F, 0x00, 0x7D, 0x8B, 0x17, 0xE8, 0x78, 0x48, 0x41, 0x71, 0x2B, 0x18, 0x96, 0x80, 0x11, 0xDB,
        0x68, 0x39, 0x9C, 0xD6, 0xE0, 0x72, 0x42, 0x86, 0xF0, 0x1B, 0x16, 0x0D, 0x3E, 0x12, 0x94, 0x3D,
        0x25, 0xA8, 0xA9, 0x30, 0x9E, 0x54, 0x5A, 0xD6, 0x36, 0x6C, 0xD6, 0x8C, 0x20, 0x62, 0x8F, 0xA1,
        0x6B, 0x1F, 0x7C, 0x6D, 0xB2, 0xB1, 0xC1, 0x2E, 0xAD, 0x36, 0x02, 0x9C, 0x3A, 0xCA, 0x2F, 0x09,
        0xD2, 0x45, 0x9E, 0xEB, 0xF2, 0xBC, 0x6C, 0xAA, 0x3B, 0x3E, 0x90, 0xBC, 0x38, 0x67, 0x35, 0x4D,
          },
            PublicExponent = new byte[] { 0, 1, 0, 1 },
            Coefficient = new byte[0x80]
          {
        0x0B, 0x67, 0x1C, 0x0D, 0x6C, 0x57, 0xD3, 0xE7, 0x05, 0x65, 0x94, 0x31, 0x56, 0x55, 0xFD, 0x28,
        0x08, 0xFA, 0x05, 0x8A, 0xCC, 0x55, 0x39, 0x61, 0x97, 0x63, 0xA0, 0x16, 0x27, 0x3D, 0xED, 0xC1,
        0x16, 0x40, 0x2A, 0x12, 0xEA, 0x6F, 0xD9, 0xD8, 0x58, 0x56, 0xA8, 0x56, 0x8B, 0x0D, 0x38, 0x5E,
        0x1E, 0x80, 0x3B, 0x5F, 0x40, 0x80, 0x6F, 0x62, 0x4F, 0x28, 0xA2, 0x69, 0xF3, 0xD3, 0xF7, 0xFD,
        0xB2, 0xC3, 0x52, 0x43, 0x20, 0x92, 0x9D, 0x97, 0x8D, 0xA0, 0x15, 0x07, 0x15, 0x6E, 0xA4, 0x0D,
        0x56, 0xD3, 0x37, 0x1A, 0xC4, 0x9E, 0xDF, 0x02, 0x49, 0xB8, 0x0A, 0x84, 0x62, 0xF5, 0xFA, 0xB9,
        0x3F, 0xA4, 0x09, 0x76, 0xCC, 0xAA, 0xB9, 0x9B, 0xA6, 0x4F, 0xC1, 0x6A, 0x64, 0xCE, 0xD8, 0x77,
        0xAB, 0x4B, 0xF9, 0xA0, 0xAE, 0xDA, 0xF1, 0x67, 0x87, 0x7C, 0x98, 0x5C, 0x7E, 0xB8, 0x73, 0xF5,
          },
            Modulus = new byte[0x100]
          {
        0xC6, 0xCF, 0x71, 0xE7, 0xE5, 0x9A, 0xF0, 0xD1, 0x2A, 0x2C, 0x45, 0x8B, 0xF9, 0x2A, 0x0E, 0xC1,
        0x43, 0x05, 0x8B, 0xC3, 0x71, 0x17, 0x80, 0x1D, 0xCD, 0x49, 0x7D, 0xDE, 0x35, 0x9D, 0x25, 0x9B,
        0xA0, 0xD7, 0xA0, 0xF2, 0x7D, 0x6C, 0x08, 0x7E, 0xAA, 0x55, 0x02, 0x68, 0x2B, 0x23, 0xC6, 0x44,
        0xB8, 0x44, 0x18, 0xEB, 0x56, 0xCF, 0x16, 0xA2, 0x48, 0x03, 0xC9, 0xE7, 0x4F, 0x87, 0xEB, 0x3D,
        0x30, 0xC3, 0x15, 0x88, 0xBF, 0x20, 0xE7, 0x9D, 0xFF, 0x77, 0x0C, 0xDE, 0x1D, 0x24, 0x1E, 0x63,
        0xA9, 0x4F, 0x8A, 0xBF, 0x5B, 0xBE, 0x60, 0x19, 0x68, 0x33, 0x3B, 0xFC, 0xED, 0x9F, 0x47, 0x4E,
        0x5F, 0xF8, 0xEA, 0xCB, 0x3D, 0x00, 0xBD, 0x67, 0x01, 0xF9, 0x2C, 0x6D, 0xC6, 0xAC, 0x13, 0x64,
        0xE7, 0x67, 0x14, 0xF3, 0xDC, 0x52, 0x69, 0x6A, 0xB9, 0x83, 0x2C, 0x42, 0x30, 0x13, 0x1B, 0xB2,
        0xD8, 0xA5, 0x02, 0x0D, 0x79, 0xED, 0x96, 0xB1, 0x0D, 0xF8, 0xCC, 0x0C, 0xDF, 0x81, 0x95, 0x4F,
        0x03, 0x58, 0x09, 0x57, 0x0E, 0x80, 0x69, 0x2E, 0xFE, 0xFF, 0x52, 0x77, 0xEA, 0x75, 0x28, 0xA8,
        0xFB, 0xC9, 0xBE, 0xBF, 0x9F, 0xBB, 0xB7, 0x79, 0x8E, 0x18, 0x05, 0xE1, 0x80, 0xBD, 0x50, 0x34,
        0x94, 0x81, 0xD3, 0x53, 0xC2, 0x69, 0xA2, 0xD2, 0x4C, 0xCF, 0x6C, 0xF4, 0x57, 0x2C, 0x10, 0x4A,
        0x3F, 0xFB, 0x22, 0xFD, 0x8B, 0x97, 0xE2, 0xC9, 0x5B, 0xA6, 0x2B, 0xCD, 0xD6, 0x1B, 0x6B, 0xDB,
        0x68, 0x7F, 0x4B, 0xC2, 0xA0, 0x50, 0x34, 0xC0, 0x05, 0xE5, 0x8D, 0xEF, 0x24, 0x67, 0xFF, 0x93,
        0x40, 0xCF, 0x2D, 0x62, 0xA2, 0xA0, 0x50, 0xB1, 0xF1, 0x3A, 0xA8, 0x3D, 0xFD, 0x80, 0xD1, 0xF9,
        0xB8, 0x05, 0x22, 0xAF, 0xC8, 0x35, 0x45, 0x90, 0x58, 0x8E, 0xE3, 0x3A, 0x7C, 0xBD, 0x3E, 0x27,
          },
            Prime1 = new byte[0x80]
          {
        0xFE, 0xF6, 0xBF, 0x1D, 0x69, 0xAB, 0x16, 0x25, 0x08, 0x47, 0x55, 0x6B, 0x86, 0xE4, 0x35, 0x88,
        0x72, 0x2A, 0xB1, 0x3D, 0xF8, 0xB6, 0x44, 0xCA, 0xB3, 0xAB, 0x19, 0xD1, 0x04, 0x24, 0x28, 0x0A,
        0x74, 0x55, 0xB8, 0x15, 0x45, 0x09, 0xCC, 0x13, 0x1C, 0xF2, 0xBA, 0x37, 0xA9, 0x03, 0x90, 0x8F,
        0x02, 0x10, 0xFF, 0x25, 0x79, 0x86, 0xCC, 0x18, 0x50, 0x9A, 0x10, 0x5F, 0x5B, 0x4C, 0x1C, 0x4E,
        0xB0, 0xA7, 0xE3, 0x59, 0xB1, 0x2D, 0xA0, 0xC6, 0xB0, 0x20, 0x2C, 0x21, 0x33, 0x12, 0xB3, 0xAF,
        0x72, 0x34, 0x83, 0xCD, 0x52, 0x2F, 0xAF, 0x0F, 0x20, 0x5A, 0x1B, 0xC0, 0xE2, 0xA3, 0x76, 0x34,
        0x0F, 0xD7, 0xFC, 0xC1, 0x41, 0xC9, 0xF9, 0x79, 0x40, 0x17, 0x42, 0x21, 0x3E, 0x9D, 0xFD, 0xC7,
        0xC1, 0x50, 0xDE, 0x44, 0x5A, 0xC9, 0x31, 0x89, 0x6A, 0x78, 0x05, 0xBE, 0x65, 0xB4, 0xE8, 0x2D,
          },
            Prime2 = new byte[0x80]
          {
        0xC7, 0x9E, 0x47, 0x58, 0x00, 0x7D, 0x62, 0x82, 0xB0, 0xD2, 0x22, 0x81, 0xD4, 0xA8, 0x97, 0x1B,
        0x79, 0x0C, 0x3A, 0xB0, 0xD7, 0xC9, 0x30, 0xE3, 0xC3, 0x53, 0x8E, 0x57, 0xEF, 0xF0, 0x9B, 0x9F,
        0xB3, 0x90, 0x52, 0xC6, 0x94, 0x22, 0x36, 0xAA, 0xE6, 0x4A, 0x5F, 0x72, 0x1D, 0x70, 0xE8, 0x76,
        0x58, 0xC8, 0xB2, 0x91, 0xCE, 0x9C, 0xC3, 0xE9, 0x09, 0x7F, 0x2E, 0x47, 0x97, 0xCC, 0x90, 0x39,
        0x15, 0x35, 0x31, 0xDE, 0x1F, 0x0C, 0x8C, 0x0D, 0xC1, 0xC2, 0x92, 0xBE, 0x97, 0xBF, 0x2F, 0x91,
        0xA1, 0x8C, 0x7D, 0x50, 0xA8, 0x21, 0x2F, 0xD7, 0xA2, 0x9A, 0x7E, 0xB5, 0xA7, 0x2A, 0x90, 0x02,
        0xD9, 0xF3, 0x3D, 0xD1, 0xEB, 0xB8, 0xE0, 0x5A, 0x79, 0x9E, 0x7D, 0x8D, 0xCA, 0x18, 0x6D, 0xBD,
        0x9E, 0xA1, 0x80, 0x28, 0x6B, 0x2A, 0xFE, 0x51, 0x24, 0x9B, 0x6F, 0x4D, 0x84, 0x77, 0x80, 0x23,
          },
        };
        public static RSAKeyset DebugRifKeyset = new RSAKeyset
        {
            PrivateExponent = new byte[256]
          {
        0x01, 0x61, 0xAD, 0xD8, 0x9C, 0x06, 0x89, 0xD0, 0x60, 0xC8, 0x41, 0xF0, 0xB3, 0x83, 0x01, 0x5D,
        0xE3, 0xA2, 0x6B, 0xA2, 0xBA, 0x9A, 0x0A, 0x58, 0xCD, 0x1A, 0xA0, 0x97, 0x64, 0xEC, 0xD0, 0x31,
        0x1F, 0xCA, 0x36, 0x0E, 0x69, 0xDD, 0x40, 0xF7, 0x4E, 0xC0, 0xC6, 0xA3, 0x73, 0xF0, 0x69, 0x84,
        0xB2, 0xF4, 0x4B, 0x29, 0x14, 0x2A, 0x6D, 0xB8, 0x23, 0xD8, 0x1B, 0x61, 0xD4, 0x9E, 0x87, 0xB3,
        0xBB, 0xA9, 0xC4, 0x85, 0x4A, 0xF8, 0x03, 0x4A, 0xBF, 0xFE, 0xF9, 0xFE, 0x8B, 0xDD, 0x54, 0x83,
        0xBA, 0xE0, 0x2F, 0x3F, 0xB1, 0xEF, 0xA5, 0x05, 0x5D, 0x28, 0x8B, 0xAB, 0xB5, 0xD0, 0x23, 0x2F,
        0x8A, 0xCF, 0x48, 0x7C, 0xAA, 0xBB, 0xC8, 0x5B, 0x36, 0x27, 0xC5, 0x16, 0xA4, 0xB6, 0x61, 0xAC,
        0x0C, 0x28, 0x47, 0x79, 0x3F, 0x38, 0xAE, 0x5E, 0x25, 0xC6, 0xAF, 0x35, 0xAE, 0xBC, 0xB0, 0xF3,
        0xBC, 0xBD, 0xFD, 0xA4, 0x87, 0x0D, 0x14, 0x3D, 0x90, 0xE4, 0xDE, 0x5D, 0x1D, 0x46, 0x81, 0xF1,
        0x28, 0x6D, 0x2F, 0x2C, 0x5E, 0x97, 0x2D, 0x89, 0x2A, 0x51, 0x72, 0x3C, 0x20, 0x02, 0x59, 0xB1,
        0x98, 0x93, 0x05, 0x1E, 0x3F, 0xA1, 0x8A, 0x69, 0x30, 0x0E, 0x70, 0x84, 0x8B, 0xAE, 0x97, 0xA1,
        0x08, 0x95, 0x63, 0x4C, 0xC7, 0xE8, 0x5D, 0x59, 0xCA, 0x78, 0x2A, 0x23, 0x87, 0xAC, 0x6F, 0x04,
        0x33, 0xB1, 0x61, 0xB9, 0xF0, 0x95, 0xDA, 0x33, 0xCC, 0xE0, 0x4C, 0x82, 0x68, 0x82, 0x14, 0x51,
        0xBE, 0x49, 0x1C, 0x58, 0xA2, 0x8B, 0x05, 0x4E, 0x98, 0x37, 0xEB, 0x94, 0x0B, 0x01, 0x22, 0xDC,
        0xB3, 0x19, 0xCA, 0x77, 0xA6, 0x6E, 0x97, 0xFF, 0x8A, 0x53, 0x5A, 0xC5, 0x24, 0xE4, 0xAF, 0x6E,
        0xA8, 0x2B, 0x53, 0xA4, 0xBE, 0x96, 0xA5, 0x7B, 0xCE, 0x22, 0x56, 0xA3, 0xF1, 0xCF, 0x14, 0xA5,
          },
            Exponent1 = new byte[128]
          {
        0xCD, 0x9A, 0x61, 0xB0, 0xB8, 0xD5, 0xB4, 0xE4, 0xE4, 0xF6, 0xAB, 0xF7, 0x27, 0xB7, 0x56, 0x59,
        0x6B, 0xB9, 0x11, 0xE7, 0xF4, 0x83, 0xAF, 0xB9, 0x73, 0x99, 0x7F, 0x49, 0xA2, 0x9C, 0xF0, 0xB5,
        0x6D, 0x37, 0x82, 0x14, 0x15, 0xF1, 0x04, 0x8A, 0xD4, 0x8E, 0xEB, 0x2E, 0x1F, 0xE2, 0x81, 0xA9,
        0x62, 0x6E, 0xB1, 0x68, 0x75, 0x62, 0xF3, 0x0F, 0xFE, 0xD4, 0x91, 0x87, 0x98, 0x78, 0xBF, 0x26,
        0xB5, 0x07, 0x58, 0xD0, 0xEE, 0x3F, 0x21, 0xE8, 0xC8, 0x0F, 0x5F, 0xFA, 0x1C, 0x64, 0x74, 0x49,
        0x52, 0xEB, 0xE7, 0xEE, 0xDE, 0xBA, 0x23, 0x26, 0x4A, 0xF6, 0x9C, 0x1A, 0x09, 0x3F, 0xB9, 0x0B,
        0x36, 0x26, 0x1A, 0xBE, 0xA9, 0x76, 0xE6, 0xF2, 0x69, 0xDE, 0xFF, 0xAF, 0xCC, 0x0C, 0x9A, 0x66,
        0x03, 0x86, 0x0A, 0x1F, 0x49, 0xA4, 0x10, 0xB6, 0xBC, 0xC3, 0x7C, 0x88, 0xE8, 0xCE, 0x4B, 0xD9,
          },
            Exponent2 = new byte[128]
          {
        0xB3, 0x73, 0xA3, 0x59, 0xE6, 0x97, 0xC0, 0xAB, 0x3B, 0x68, 0xFC, 0x39, 0xAC, 0xDB, 0x44, 0xB1,
        0xB4, 0x9E, 0x35, 0x4D, 0xBE, 0xC5, 0x36, 0x69, 0x6C, 0x3D, 0xC5, 0xFC, 0xFE, 0x4B, 0x2F, 0xDC,
        0x86, 0x80, 0x46, 0x96, 0x40, 0x1A, 0x0D, 0x6E, 0xFA, 0x8C, 0xE0, 0x47, 0x91, 0xAC, 0xAD, 0x95,
        0x2B, 0x8E, 0x1F, 0xF2, 0x0A, 0x45, 0xF8, 0x29, 0x95, 0x70, 0xC6, 0x88, 0x5F, 0x71, 0x03, 0x99,
        0x79, 0xBC, 0x84, 0x71, 0xBD, 0xE8, 0x84, 0x8C, 0x0E, 0xD4, 0x7B, 0x30, 0x74, 0x57, 0x1A, 0x95,
        0xE7, 0x90, 0x19, 0x8D, 0xAD, 0x8B, 0x4C, 0x4E, 0xC3, 0xE7, 0x6B, 0x23, 0x86, 0x01, 0xEE, 0x9B,
        0xE0, 0x2F, 0x15, 0xA2, 0x2C, 0x4C, 0x39, 0xD3, 0xDF, 0x9C, 0x39, 0x01, 0xF1, 0x8C, 0x44, 0x4A,
        0x15, 0x44, 0xDC, 0x51, 0xF7, 0x22, 0xD7, 0x7F, 0x41, 0x7F, 0x68, 0xFA, 0xEE, 0x56, 0xE8, 0x05,
          },
            PublicExponent = new byte[] { 0x00, 0x01, 0x00, 0x01 },
            Coefficient = new byte[128]
          {
        0xC0, 0x32, 0x43, 0xD3, 0x8C, 0x3D, 0xB4, 0xD2, 0x48, 0x8C, 0x42, 0x41, 0x24, 0x94, 0x6C, 0x80,
        0xC9, 0xC1, 0x79, 0x36, 0x7F, 0xAC, 0xC3, 0xFF, 0x6A, 0x25, 0xEB, 0x2C, 0xFB, 0xD4, 0x2B, 0xA0,
        0xEB, 0xFE, 0x25, 0xE9, 0xC6, 0x77, 0xCE, 0xFE, 0x2D, 0x23, 0xFE, 0xD0, 0xF4, 0x0F, 0xD9, 0x7E,
        0xD5, 0xA5, 0x7D, 0x1F, 0xC0, 0xE8, 0xE8, 0xEC, 0x80, 0x5B, 0xC7, 0xFD, 0xE2, 0xBD, 0x94, 0xA6,
        0x2B, 0xDD, 0x6A, 0x60, 0x45, 0x54, 0xAB, 0xCA, 0x42, 0x9C, 0x6A, 0x6C, 0xBF, 0x3C, 0x84, 0xF9,
        0xA5, 0x0E, 0x63, 0x0C, 0x51, 0x58, 0x62, 0x6D, 0x5A, 0xB7, 0x3C, 0x3F, 0x49, 0x1A, 0xD0, 0x93,
        0xB8, 0x4F, 0x1A, 0x6C, 0x5F, 0xC5, 0xE5, 0xA9, 0x75, 0xD4, 0x86, 0x9E, 0xDF, 0x87, 0x0F, 0x27,
        0xB0, 0x26, 0x78, 0x4E, 0xFB, 0xC1, 0x8A, 0x4A, 0x24, 0x3F, 0x7F, 0x8F, 0x9A, 0x12, 0x51, 0xCB,
          },
            Modulus = new byte[]
          {
        0xC2, 0xD2, 0x44, 0xBC, 0xDD, 0x84, 0x3F, 0xD9, 0xC5, 0x22, 0xAF, 0xF7, 0xFC, 0x88, 0x8A, 0x33,
        0x80, 0xED, 0x8E, 0xE2, 0xCC, 0x81, 0xF7, 0xEC, 0xF8, 0x1C, 0x79, 0xBF, 0x02, 0xBB, 0x12, 0x8E,
        0x61, 0x68, 0x29, 0x1B, 0x15, 0xB6, 0x5E, 0xC6, 0xF8, 0xBF, 0x5A, 0xE0, 0x3B, 0x6A, 0x6C, 0xD9,
        0xD6, 0xF5, 0x75, 0xAB, 0xA0, 0x6F, 0x34, 0x81, 0x34, 0x9A, 0x5B, 0xAD, 0xED, 0x31, 0xE3, 0xC6,
        0xEA, 0x1A, 0xD1, 0x13, 0x22, 0xBB, 0xB3, 0xDA, 0xB3, 0xB2, 0x53, 0xBD, 0x45, 0x79, 0x87, 0xAD,
        0x0A, 0x01, 0x72, 0x18, 0x10, 0x29, 0x49, 0xF4, 0x41, 0x7F, 0xD6, 0x47, 0x0C, 0x72, 0x92, 0x9E,
        0xE9, 0xBB, 0x95, 0xA9, 0x5D, 0x79, 0xEB, 0xE4, 0x30, 0x76, 0x90, 0x45, 0x4B, 0x9D, 0x9C, 0xCF,
        0x92, 0x03, 0x60, 0x8C, 0x4B, 0x6C, 0xB3, 0x7A, 0x3A, 0x05, 0x39, 0xA0, 0x66, 0xA9, 0x35, 0xCF,
        0xB9, 0xFA, 0xAD, 0x9C, 0xAB, 0xEB, 0xE4, 0x6A, 0x8C, 0xE9, 0x3B, 0xCC, 0x72, 0x12, 0x62, 0x63,
        0xBD, 0x80, 0xC4, 0xEE, 0x37, 0x2B, 0x32, 0x03, 0xA3, 0x09, 0xF7, 0xA0, 0x61, 0x57, 0xAD, 0x0D,
        0xCF, 0x15, 0x98, 0x9E, 0x4E, 0x49, 0xF8, 0xB5, 0xA3, 0x5C, 0x27, 0xEE, 0x45, 0x04, 0xEA, 0xE4,
        0x4B, 0xBC, 0x8F, 0x87, 0xED, 0x19, 0x1E, 0x46, 0x75, 0x63, 0xC4, 0x5B, 0xD5, 0xBC, 0x09, 0x2F,
        0x02, 0x73, 0x19, 0x3C, 0x58, 0x55, 0x49, 0x66, 0x4C, 0x11, 0xEC, 0x0F, 0x09, 0xFA, 0xA5, 0x56,
        0x0A, 0x5A, 0x63, 0x56, 0xAD, 0xA0, 0x0D, 0x86, 0x08, 0xC1, 0xE6, 0xB6, 0x13, 0x22, 0x49, 0x2F,
        0x7C, 0xDB, 0x4C, 0x56, 0x97, 0x0E, 0xC2, 0xD9, 0x2E, 0x87, 0xBC, 0x0E, 0x67, 0xC0, 0x1B, 0x58,
        0xBC, 0x64, 0x2B, 0xC2, 0x6E, 0xE2, 0x93, 0x2E, 0xB5, 0x6B, 0x70, 0xA4, 0x42, 0x9F, 0x64, 0xC1
          },
            Prime1 = new byte[] {
        0xE5, 0x62, 0xE1, 0x7F, 0x9F, 0x86, 0x08, 0xE2, 0x61, 0xD3, 0xD0, 0x42, 0xE2, 0xC4, 0xB6, 0xA8,
        0x51, 0x09, 0x19, 0x14, 0xA4, 0x3A, 0x11, 0x4C, 0x33, 0xA5, 0x9C, 0x01, 0x5E, 0x34, 0xB6, 0x3F,
        0x02, 0x1A, 0xCA, 0x47, 0xF1, 0x4F, 0x3B, 0x35, 0x2A, 0x07, 0x20, 0xEC, 0xD8, 0xC1, 0x15, 0xD9,
        0xCA, 0x03, 0x4F, 0xB8, 0xE8, 0x09, 0x73, 0x3F, 0x85, 0xB7, 0x41, 0xD5, 0x51, 0x3E, 0x7B, 0xE3,
        0x53, 0x2B, 0x48, 0x8B, 0x8E, 0xCB, 0xBA, 0xF7, 0xE0, 0x60, 0xF5, 0x35, 0x0E, 0x6F, 0xB0, 0xD9,
        0x2A, 0x99, 0xD0, 0xFF, 0x60, 0x14, 0xED, 0x40, 0xEA, 0xF8, 0xD7, 0x0B, 0xC3, 0x8D, 0x8C, 0xE8,
        0x81, 0xB3, 0x75, 0x93, 0x15, 0xB3, 0x7D, 0xF6, 0x39, 0x60, 0x1A, 0x00, 0xE7, 0xC3, 0x27, 0xAD,
        0xA4, 0x33, 0xD5, 0x3E, 0xA4, 0x35, 0x48, 0x6F, 0x22, 0xEF, 0x5D, 0xDD, 0x7D, 0x7B, 0x61, 0x05
      },
            Prime2 = new byte[]
          {
        0xD9, 0x6C, 0xC2, 0x0C, 0xF7, 0xAE, 0xD1, 0xF3, 0x3B, 0x3B, 0x49, 0x1E, 0x9F, 0x12, 0x9C, 0xA1,
        0x78, 0x1F, 0x35, 0x1D, 0x98, 0x26, 0x13, 0x71, 0xF9, 0x09, 0xFD, 0xF0, 0xAD, 0x38, 0x55, 0xB7,
        0xEE, 0x61, 0x04, 0x72, 0x51, 0x87, 0x2E, 0x05, 0x84, 0xB1, 0x1D, 0x0C, 0x0D, 0xDB, 0xD4, 0x25,
        0x3E, 0x26, 0xED, 0xEA, 0xB8, 0xF7, 0x49, 0xFE, 0xA2, 0x94, 0xE6, 0xF2, 0x08, 0x92, 0xA7, 0x85,
        0xF5, 0x30, 0xB9, 0x84, 0x22, 0xBF, 0xCA, 0xF0, 0x5F, 0xCB, 0x31, 0x20, 0x34, 0x49, 0x16, 0x76,
        0x34, 0xCC, 0x7A, 0xCB, 0x96, 0xFE, 0x78, 0x7A, 0x41, 0xFE, 0x9A, 0xA2, 0x23, 0xF7, 0x68, 0x80,
        0xD6, 0xCE, 0x4A, 0x78, 0xA5, 0xB7, 0x05, 0x77, 0x81, 0x1F, 0xDE, 0x5E, 0xA8, 0x6E, 0x3E, 0x87,
        0xEC, 0x44, 0xD2, 0x69, 0xC6, 0x54, 0x91, 0x6B, 0x5E, 0x13, 0x8A, 0x03, 0x87, 0x05, 0x31, 0x8D
          },
        };
        /// <summary>
        /// Modulus is in PkgPublicKeys[3], fortunately we have the whole thing!
        /// </summary>
        public static RSAKeyset PkgDerivedKey3Keyset = new RSAKeyset
        {
            Prime1 = new byte[]
          {
        0xF9, 0x67, 0xAD, 0x99, 0x12, 0x31, 0x0C, 0x56, 0xA2, 0x2E, 0x16, 0x1C, 0x46, 0xB3, 0x4D, 0x5B,
        0x43, 0xBE, 0x42, 0xA2, 0xF6, 0x86, 0x96, 0x80, 0x42, 0xC3, 0xC7, 0x3F, 0xC3, 0x42, 0xF5, 0x87,
        0x49, 0x33, 0x9F, 0x07, 0x5D, 0x6E, 0x2C, 0x04, 0xFD, 0xE3, 0xE1, 0xB2, 0xAE, 0x0A, 0x0C, 0xF0,
        0xC7, 0xA6, 0x1C, 0xA1, 0x63, 0x50, 0xC8, 0x09, 0x9C, 0x51, 0x24, 0x52, 0x6C, 0x5E, 0x5E, 0xBD,
        0x1E, 0x27, 0x06, 0xBB, 0xBC, 0x9E, 0x94, 0xE1, 0x35, 0xD4, 0x6D, 0xB3, 0xCB, 0x3C, 0x68, 0xDD,
        0x68, 0xB3, 0xFE, 0x6C, 0xCB, 0x8D, 0x82, 0x20, 0x76, 0x23, 0x63, 0xB7, 0xE9, 0x68, 0x10, 0x01,
        0x4E, 0xDC, 0xBA, 0x27, 0x5D, 0x01, 0xC1, 0x2D, 0x80, 0x5E, 0x2B, 0xAF, 0x82, 0x6B, 0xD8, 0x84,
        0xB6, 0x10, 0x52, 0x86, 0xA7, 0x89, 0x8E, 0xAE, 0x9A, 0xE2, 0x89, 0xC6, 0xF7, 0xD5, 0x87, 0xFB,
          },
            Prime2 = new byte[]
          {
        0xD7, 0xA1, 0x0F, 0x9A, 0x8B, 0xF2, 0xC9, 0x11, 0x95, 0x32, 0x9A, 0x8C, 0xF0, 0xD9, 0x40, 0x47,
        0xF5, 0x68, 0xA0, 0x0D, 0xBD, 0xC1, 0xFC, 0x43, 0x2F, 0x65, 0xF9, 0xC3, 0x61, 0x0F, 0x25, 0x77,
        0x54, 0xAD, 0xD7, 0x58, 0xAC, 0x84, 0x40, 0x60, 0x8D, 0x3F, 0xF3, 0x65, 0x89, 0x75, 0xB5, 0xC6,
        0x2C, 0x51, 0x1A, 0x2F, 0x1F, 0x22, 0xE4, 0x43, 0x11, 0x54, 0xBE, 0xC9, 0xB4, 0xC7, 0xB5, 0x1B,
        0x05, 0x0B, 0xBC, 0x56, 0x9A, 0xCD, 0x4A, 0xD9, 0x73, 0x68, 0x5E, 0x5C, 0xFB, 0x92, 0xB7, 0x8B,
        0x0D, 0xFF, 0xF5, 0x07, 0xCA, 0xB4, 0xC8, 0x9B, 0x96, 0x3C, 0x07, 0x9E, 0x3E, 0x6B, 0x2A, 0x11,
        0xF2, 0x8A, 0xB1, 0x8A, 0xD7, 0x2E, 0x1B, 0xA5, 0x53, 0x24, 0x06, 0xED, 0x50, 0xB8, 0x90, 0x67,
        0xB1, 0xE2, 0x41, 0xC6, 0x92, 0x01, 0xEE, 0x10, 0xF0, 0x61, 0xBB, 0xFB, 0xB2, 0x7D, 0x4A, 0x73,
          },
            PrivateExponent = new byte[]
          {
        0x32, 0xD9, 0x03, 0x90, 0x8F, 0xBD, 0xB0, 0x8F, 0x57, 0x2B, 0x28, 0x5E, 0x0B, 0x8D, 0xB3, 0xEA,
        0x5C, 0xD1, 0x7E, 0xA8, 0x90, 0x88, 0x8C, 0xDD, 0x6A, 0x80, 0xBB, 0xB1, 0xDF, 0xC1, 0xF7, 0x0D,
        0xAA, 0x32, 0xF0, 0xB7, 0x7C, 0xCB, 0x88, 0x80, 0x0E, 0x8B, 0x64, 0xB0, 0xBE, 0x4C, 0xD6, 0x0E,
        0x9B, 0x8C, 0x1E, 0x2A, 0x64, 0xE1, 0xF3, 0x5C, 0xD7, 0x76, 0x01, 0x41, 0x5E, 0x93, 0x5C, 0x94,
        0xFE, 0xDD, 0x46, 0x62, 0xC3, 0x1B, 0x5A, 0xE2, 0xA0, 0xBC, 0x2D, 0xEB, 0xC3, 0x98, 0x0A, 0xA7,
        0xB7, 0x85, 0x69, 0x70, 0x68, 0x2B, 0x64, 0x4A, 0xB3, 0x1F, 0xCC, 0x7D, 0xDC, 0x7C, 0x26, 0xF4,
        0x77, 0xF6, 0x5C, 0xF2, 0xAE, 0x5A, 0x44, 0x2D, 0xD3, 0xAB, 0x16, 0x62, 0x04, 0x19, 0xBA, 0xFB,
        0x90, 0xFF, 0xE2, 0x30, 0x50, 0x89, 0x6E, 0xCB, 0x56, 0xB2, 0xEB, 0xC0, 0x91, 0x16, 0x92, 0x5E,
        0x30, 0x8E, 0xAE, 0xC7, 0x94, 0x5D, 0xFD, 0x35, 0xE1, 0x20, 0xF8, 0xAD, 0x3E, 0xBC, 0x08, 0xBF,
        0xC0, 0x36, 0x74, 0x9F, 0xD5, 0xBB, 0x52, 0x08, 0xFD, 0x06, 0x66, 0xF3, 0x7A, 0xB3, 0x04, 0xF4,
        0x75, 0x29, 0x5D, 0xE9, 0x5F, 0xAA, 0x10, 0x30, 0xB2, 0x0F, 0x5A, 0x1A, 0xC1, 0x2A, 0xB3, 0xFE,
        0xCB, 0x21, 0xAD, 0x80, 0xEC, 0x8F, 0x20, 0x09, 0x1C, 0xDB, 0xC5, 0x58, 0x94, 0xC2, 0x9C, 0xC6,
        0xCE, 0x82, 0x65, 0x3E, 0x57, 0x90, 0xBC, 0xA9, 0x8B, 0x06, 0xB4, 0xF0, 0x72, 0xF6, 0x77, 0xDF,
        0x98, 0x64, 0xF1, 0xEC, 0xFE, 0x37, 0x2D, 0xBC, 0xAE, 0x8C, 0x08, 0x81, 0x1F, 0xC3, 0xC9, 0x89,
        0x1A, 0xC7, 0x42, 0x82, 0x4B, 0x2E, 0xDC, 0x8E, 0x8D, 0x73, 0xCE, 0xB1, 0xCC, 0x01, 0xD9, 0x08,
        0x70, 0x87, 0x3C, 0x44, 0x08, 0xEC, 0x49, 0x8F, 0x81, 0x5A, 0xE2, 0x40, 0xFF, 0x77, 0xFC, 0x0D,
          },
            Exponent1 = new byte[]
          {
        0x52, 0xCC, 0x2D, 0xA0, 0x9C, 0x9E, 0x75, 0xE7, 0x28, 0xEE, 0x3D, 0xDE, 0xE3, 0x45, 0xD1, 0x4F,
        0x94, 0x1C, 0xCC, 0xC8, 0x87, 0x29, 0x45, 0x3B, 0x8D, 0x6E, 0xAB, 0x6E, 0x2A, 0xA7, 0xC7, 0x15,
        0x43, 0xA3, 0x04, 0x8F, 0x90, 0x5F, 0xEB, 0xF3, 0x38, 0x4A, 0x77, 0xFA, 0x36, 0xB7, 0x15, 0x76,
        0xB6, 0x01, 0x1A, 0x8E, 0x25, 0x87, 0x82, 0xF1, 0x55, 0xD8, 0xC6, 0x43, 0x2A, 0xC0, 0xE5, 0x98,
        0xC9, 0x32, 0xD1, 0x94, 0x6F, 0xD9, 0x01, 0xBA, 0x06, 0x81, 0xE0, 0x6D, 0x88, 0xF2, 0x24, 0x2A,
        0x25, 0x01, 0x64, 0x5C, 0xBF, 0xF2, 0xD9, 0x99, 0x67, 0x3E, 0xF6, 0x72, 0xEE, 0xE4, 0xE2, 0x33,
        0x5C, 0xF8, 0x00, 0x40, 0xE3, 0x2A, 0x9A, 0xF4, 0x3D, 0x22, 0x86, 0x44, 0x3C, 0xFB, 0x0A, 0xA5,
        0x7C, 0x3F, 0xCC, 0xF5, 0xF1, 0x16, 0xC4, 0xAC, 0x88, 0xB4, 0xDE, 0x62, 0x94, 0x92, 0x6A, 0x13,
          },
            Exponent2 = new byte[]
          {
        0x7C, 0x9D, 0xAD, 0x39, 0xE0, 0xD5, 0x60, 0x14, 0x94, 0x48, 0x19, 0x7F, 0x88, 0x95, 0xD5, 0x8B,
        0x80, 0xAD, 0x85, 0x8A, 0x4B, 0x77, 0x37, 0x85, 0xD0, 0x77, 0xBB, 0xBF, 0x89, 0x71, 0x4A, 0x72,
        0xCB, 0x72, 0x68, 0x38, 0xEC, 0x02, 0xC6, 0x7D, 0xC6, 0x44, 0x06, 0x33, 0x51, 0x1C, 0xC0, 0xFF,
        0x95, 0x8F, 0x0D, 0x75, 0xDC, 0x25, 0xBB, 0x0B, 0x73, 0x91, 0xA9, 0x6D, 0x42, 0xD8, 0x03, 0xB7,
        0x68, 0xD4, 0x1E, 0x75, 0x62, 0xA3, 0x70, 0x35, 0x79, 0x78, 0x00, 0xC8, 0xF5, 0xEF, 0x15, 0xB9,
        0xFC, 0x4E, 0x47, 0x5A, 0xC8, 0x70, 0x70, 0x5B, 0x52, 0x98, 0xC0, 0xC2, 0x58, 0x4A, 0x70, 0x96,
        0xCC, 0xB8, 0x10, 0xE1, 0x2F, 0x78, 0x8B, 0x2B, 0xA1, 0x7F, 0xF9, 0xAC, 0xDE, 0xF0, 0xBB, 0x2B,
        0xE2, 0x66, 0xE3, 0x22, 0x92, 0x31, 0x21, 0x57, 0x92, 0xC4, 0xB8, 0xF2, 0x3E, 0x76, 0x20, 0x37,
          },
            Coefficient = new byte[]
          {
        0x45, 0x97, 0x55, 0xD4, 0x22, 0x08, 0x5E, 0xF3, 0x5C, 0xB4, 0x05, 0x7A, 0xFD, 0xAA, 0x42, 0x42,
        0xAD, 0x9A, 0x8C, 0xA0, 0x6C, 0xBB, 0x1D, 0x68, 0x54, 0x54, 0x6E, 0x3E, 0x32, 0xE3, 0x53, 0x73,
        0x76, 0xF1, 0x3E, 0x01, 0xEA, 0xD3, 0xCF, 0xEB, 0xEB, 0x23, 0x3E, 0xC0, 0xBE, 0xCE, 0xEC, 0x2C,
        0x89, 0x5F, 0xA8, 0x27, 0x3A, 0x4C, 0xB7, 0xE6, 0x74, 0xBC, 0x45, 0x4C, 0x26, 0xC8, 0x25, 0xFF,
        0x34, 0x63, 0x25, 0x37, 0xE1, 0x48, 0x10, 0xC1, 0x93, 0xA6, 0xAF, 0xEB, 0xBA, 0xE3, 0xA2, 0xF1,
        0x3D, 0xEF, 0x63, 0xD8, 0xF4, 0xFD, 0xD3, 0xEE, 0xE2, 0x5D, 0xE9, 0x33, 0xCC, 0xAD, 0xBA, 0x75,
        0x5C, 0x85, 0xAF, 0xCE, 0xA9, 0x3D, 0xD1, 0xA2, 0x17, 0xF3, 0xF6, 0x98, 0xB3, 0x50, 0x8E, 0x5E,
        0xF6, 0xEB, 0x02, 0x8E, 0xA1, 0x62, 0xA7, 0xD6, 0x2C, 0xEC, 0x91, 0xFF, 0x15, 0x40, 0xD2, 0xE3,
          },
            Modulus = new byte[]
          {
        0xd2, 0x12, 0xfc, 0x33, 0x5f, 0x6d, 0xdb, 0x83, 0x16, 0x09, 0x62, 0x8b, 0x03, 0x56, 0x27, 0x37,
        0x82, 0xd4, 0x77, 0x85, 0x35, 0x29, 0x39, 0x2d, 0x52, 0x6b, 0x8c, 0x4c, 0x8c, 0xfb, 0x06, 0xc1,
        0x84, 0x5b, 0xe7, 0xd4, 0xf7, 0xbc, 0xd2, 0x4e, 0x62, 0x45, 0xcd, 0x2a, 0xbb, 0xd7, 0x77, 0x76,
        0x45, 0x36, 0x55, 0x27, 0x3f, 0xb3, 0xf5, 0xf9, 0x8e, 0xda, 0x4b, 0xef, 0xaa, 0x59, 0xae, 0xb3,
        0x9b, 0xea, 0x54, 0x98, 0xd2, 0x06, 0x32, 0x6a, 0x58, 0x31, 0x2a, 0xe0, 0xd4, 0x4f, 0x90, 0xb5,
        0x0a, 0x7d, 0xec, 0xf4, 0x3a, 0x9c, 0x52, 0x67, 0x2d, 0x99, 0x31, 0x8e, 0x0c, 0x43, 0xe6, 0x82,
        0xfe, 0x07, 0x46, 0xe1, 0x2e, 0x50, 0xd4, 0x1f, 0x2d, 0x2f, 0x7e, 0xd9, 0x08, 0xba, 0x06, 0xb3,
        0xbf, 0x2e, 0x20, 0x3f, 0x4e, 0x3f, 0xfe, 0x44, 0xff, 0xaa, 0x50, 0x43, 0x57, 0x91, 0x69, 0x94,
        0x49, 0x15, 0x82, 0x82, 0xe4, 0x0f, 0x4c, 0x8d, 0x9d, 0x2c, 0xc9, 0x5b, 0x1d, 0x64, 0xbf, 0x88,
        0x8b, 0xd4, 0xc5, 0x94, 0xe7, 0x65, 0x47, 0x84, 0x1e, 0xe5, 0x79, 0x10, 0xfb, 0x98, 0x93, 0x47,
        0xb9, 0x7d, 0x85, 0x12, 0xa6, 0x40, 0x98, 0x2c, 0xf7, 0x92, 0xbc, 0x95, 0x19, 0x32, 0xed, 0xe8,
        0x90, 0x56, 0x0d, 0x65, 0xc1, 0xaa, 0x78, 0xc6, 0x2e, 0x54, 0xfd, 0x5f, 0x54, 0xa1, 0xf6, 0x7e,
        0xe5, 0xe0, 0x5f, 0x61, 0xc1, 0x20, 0xb4, 0xb9, 0xb4, 0x33, 0x08, 0x70, 0xe4, 0xdf, 0x89, 0x56,
        0xed, 0x01, 0x29, 0x46, 0x77, 0x5f, 0x8c, 0xb8, 0xa9, 0xf5, 0x1e, 0x2e, 0xb3, 0xb9, 0xbf, 0xe0,
        0x09, 0xb7, 0x8d, 0x28, 0xd4, 0xa6, 0xc3, 0xb8, 0x1e, 0x1f, 0x07, 0xeb, 0xb4, 0x12, 0x0b, 0x95,
        0xb8, 0x85, 0x30, 0xfd, 0xdc, 0x39, 0x13, 0xd0, 0x7c, 0xdc, 0x8f, 0xed, 0xf9, 0xc9, 0xa3, 0xc1,
          },
            PublicExponent = new byte[] { 0, 1, 0, 1 }
        };
    }
    public static class Keys
    {
        public static byte[] rif_debug_key = new byte[0x10]
        {
      0x96, 0xC2, 0x26, 0x8D, 0x69, 0x26, 0x1C, 0x8B, 0x1E, 0x3B, 0x6B, 0xFF, 0x2F, 0xE0, 0x4E, 0x12
        };

        // we mark our key using some pattern that we can check later
        public static byte[] s_fake_key_seed = new byte[0x10]
        {
      0x46, 0x41, 0x4B, 0x45, 0x46, 0x41, 0x4B, 0x45, 0x46, 0x41, 0x4B, 0x45, 0x46, 0x41, 0x4B, 0x45,
        };

        public static byte[] unk_aes_key = new byte[0x10]
        {
      0x02, 0xCC, 0xD3, 0x46, 0xB4, 0x59, 0xCB, 0x83, 0x50, 0x5E, 0x8E, 0x76, 0x0A, 0x44, 0xD4, 0x57
        };

        /// <summary>
        /// Used to hash the first SHA256-HMAC in keystone
        /// </summary>
        public static byte[] keystone_hmac_key = new byte[0x20]
        {
      0xC7, 0x44, 0x05, 0xF6, 0x74, 0x24, 0xBA, 0x34, 0x2B, 0xC1, 0x27, 0x62, 0x51, 0xBB, 0xC2, 0xF5,
      0x55, 0xF1, 0x60, 0x25, 0xB6, 0xA1, 0xB6, 0x71, 0x47, 0x80, 0xDB, 0xAE, 0xC8, 0x52, 0xFA, 0x2F,
        };

        /// <summary>
        /// Used to hash the second SHA256-HMAC in keystone
        /// </summary>
        public static byte[] keystone_mac_data = new byte[0x20]
        {
      0x78, 0x3D, 0x6F, 0x3A, 0xE9, 0x1C, 0x0E, 0x07, 0x12, 0xFC, 0xAA, 0xB7, 0x95, 0x0B, 0xDE, 0x06,
      0x85, 0x5C, 0xF7, 0xA2, 0x2D, 0xCD, 0xBD, 0xE1, 0x27, 0xE9, 0xBF, 0xCB, 0xAD, 0x0F, 0xF0, 0xFE
        };

        /// <summary>
        /// Used to encrypt the passcode, derived keys, and Package digest
        /// </summary>
        public static byte[][] PkgPublicKeys = new byte[][]
        {
      // Used to encrypt Passcode in ENTRY_KEYS
      new byte[]
      {
        0xd6, 0xaa, 0x0c, 0x5c, 0x0d, 0x6d, 0xc9, 0xe5, 0xee, 0x28, 0xf9, 0xaa, 0x8d, 0xbc, 0x72, 0x36,
        0x69, 0x96, 0x17, 0xb6, 0x5f, 0x8a, 0x4d, 0x96, 0x9c, 0x88, 0x41, 0x33, 0x0c, 0xb3, 0xfb, 0xa0,
        0xd6, 0x33, 0x2d, 0x20, 0x2f, 0xe3, 0x0d, 0xad, 0xe0, 0x7a, 0x3e, 0x4a, 0x28, 0x2f, 0x76, 0x29,
        0x1b, 0x4f, 0x8a, 0x34, 0x74, 0x36, 0xc8, 0xc9, 0x40, 0x46, 0x4d, 0xb2, 0xbe, 0xed, 0xcb, 0x72,
        0x3e, 0x81, 0xff, 0xa3, 0xac, 0x52, 0xa2, 0x45, 0x13, 0xc7, 0x81, 0xb2, 0x21, 0x5c, 0xbe, 0x97,
        0x9d, 0x07, 0x0e, 0x8f, 0xc8, 0x46, 0xe9, 0xbb, 0xa6, 0xa5, 0x6e, 0xd4, 0x48, 0x87, 0xbb, 0xe6,
        0xf6, 0x0c, 0x48, 0x66, 0x50, 0x10, 0x9a, 0xab, 0x0f, 0x36, 0xb0, 0x1f, 0x28, 0xe0, 0x56, 0xe4,
        0x08, 0xd3, 0x76, 0x62, 0x9f, 0x07, 0x03, 0x26, 0x36, 0x76, 0xb5, 0x8e, 0xb3, 0x73, 0x92, 0x66,
        0x58, 0x57, 0x94, 0x3a, 0xcf, 0xbc, 0x21, 0x2b, 0xa0, 0x08, 0xba, 0x2c, 0x37, 0x81, 0x18, 0xf7,
        0xd8, 0x1e, 0xa9, 0x1a, 0x45, 0x68, 0x95, 0xbf, 0x16, 0x86, 0x17, 0x35, 0x30, 0x9a, 0x79, 0xbf,
        0xa9, 0xdb, 0x96, 0xc2, 0x1f, 0x0d, 0x9f, 0xfc, 0x8b, 0x3b, 0x4f, 0x81, 0xea, 0xad, 0x87, 0xf6,
        0x73, 0x0f, 0x70, 0x9a, 0x29, 0x18, 0x39, 0x8e, 0x9c, 0x36, 0x9a, 0x23, 0xbc, 0x94, 0x06, 0x9b,
        0x1b, 0x7b, 0x34, 0xa1, 0x8b, 0x5f, 0x06, 0xc4, 0x79, 0x65, 0xe9, 0x65, 0xb3, 0xfb, 0xf6, 0x13,
        0x2f, 0xb7, 0xc0, 0xb5, 0x4e, 0x48, 0x8e, 0xb6, 0x61, 0xa9, 0x95, 0xd8, 0x3e, 0x7f, 0x57, 0xe0,
        0x7b, 0x4e, 0x21, 0x25, 0x09, 0x6f, 0x5f, 0x47, 0x4d, 0x33, 0x3c, 0x06, 0x34, 0xae, 0x85, 0xe8,
        0x9d, 0x48, 0x06, 0xbd, 0xd1, 0xee, 0x0c, 0x9c, 0xef, 0x63, 0x41, 0x4c, 0x26, 0xfd, 0xc8, 0x8f,
      },
      // Used to encrypt EKPFS in ENTRY_KEYS
      new byte[]
      {
        0xb9, 0x69, 0x53, 0xee, 0xa5, 0x4b, 0x1e, 0xb2, 0xf7, 0x15, 0xea, 0xb6, 0x21, 0x72, 0xbc, 0xec,
        0x4d, 0x8f, 0xd3, 0x9d, 0x48, 0x36, 0x09, 0xd4, 0xf6, 0x32, 0x04, 0x3a, 0xab, 0x20, 0x57, 0xd9,
        0x51, 0x0f, 0xed, 0x35, 0x7a, 0xf9, 0x86, 0x3c, 0xc8, 0xcf, 0x65, 0x24, 0x27, 0xdc, 0x86, 0xb2,
        0x81, 0x6c, 0x48, 0x0d, 0x5f, 0x30, 0xcb, 0x16, 0xc7, 0x33, 0xb4, 0x3e, 0xd3, 0x8c, 0xc1, 0x9c,
        0xe2, 0x1a, 0xd6, 0x82, 0xc1, 0xed, 0x92, 0x26, 0xa2, 0x40, 0x8b, 0xd4, 0xc0, 0x80, 0x7f, 0x9f,
        0xbd, 0xa6, 0x4b, 0x94, 0x20, 0x92, 0xf7, 0xf4, 0x2d, 0xcb, 0x88, 0xe5, 0x13, 0x5f, 0x92, 0xd2,
        0xb1, 0xb9, 0x09, 0x79, 0x95, 0xab, 0x0e, 0x42, 0xe3, 0xca, 0x36, 0x91, 0x15, 0x9d, 0xed, 0xa9,
        0x3a, 0xc1, 0xb0, 0xa2, 0x18, 0xd7, 0x1e, 0x12, 0x8a, 0xd2, 0xdb, 0x11, 0x4f, 0xbd, 0xe5, 0x32,
        0x8b, 0x61, 0x37, 0x53, 0xea, 0x4a, 0x4a, 0xe6, 0xfd, 0xf9, 0x4b, 0x4d, 0x8e, 0xde, 0x12, 0x0e,
        0xbf, 0x41, 0x4e, 0x3c, 0x76, 0xe0, 0xc9, 0x39, 0x8c, 0xd9, 0x2d, 0xb8, 0xa5, 0xf4, 0x88, 0x33,
        0xf3, 0x36, 0x4f, 0xa9, 0x8b, 0xbb, 0x92, 0x89, 0xec, 0xb2, 0xa8, 0xde, 0x9f, 0xd9, 0xcf, 0xed,
        0xa7, 0x4e, 0x55, 0x76, 0x9b, 0xed, 0x39, 0xc5, 0xe1, 0xab, 0x0c, 0x5d, 0x89, 0x07, 0x5e, 0x2b,
        0x33, 0x9c, 0x6d, 0xa7, 0x48, 0xaa, 0x2c, 0x57, 0x99, 0xa7, 0xd4, 0x8a, 0xff, 0x91, 0x0a, 0x55,
        0x4a, 0xaf, 0x34, 0x4a, 0x07, 0xcc, 0xed, 0x8c, 0x1d, 0xe4, 0x5c, 0x54, 0xd6, 0xb4, 0xbd, 0xda,
        0x59, 0x95, 0xf1, 0x6e, 0x64, 0xc6, 0xda, 0x01, 0x65, 0x56, 0x25, 0x47, 0x79, 0x85, 0x5e, 0x4c,
        0x97, 0x68, 0xe7, 0xfd, 0xdf, 0xd7, 0xd7, 0xdf, 0x56, 0xbd, 0x17, 0x3f, 0xa5, 0xdd, 0xce, 0xdd,
      },
      new byte[]
      {
        0x9d, 0x2a, 0x60, 0xa2, 0x53, 0x8f, 0xa2, 0x18, 0xd1, 0xa6, 0x36, 0xde, 0x7c, 0xce, 0x7a, 0xf8,
        0x95, 0x0b, 0x72, 0x6b, 0x52, 0x75, 0x3a, 0x24, 0x19, 0xa4, 0x54, 0x5c, 0xa7, 0x5e, 0xcc, 0xb3,
        0x43, 0xab, 0xae, 0x83, 0x84, 0xca, 0x0b, 0x7f, 0xfd, 0x26, 0x9d, 0x7e, 0x4d, 0x36, 0x9d, 0x05,
        0x47, 0xaa, 0xda, 0x16, 0xf3, 0x3a, 0x56, 0xeb, 0x9e, 0x37, 0x65, 0x7c, 0xfc, 0xd9, 0x3e, 0xde,
        0xe6, 0x2b, 0xab, 0x09, 0x78, 0xf1, 0x5d, 0x99, 0xdd, 0x57, 0xba, 0x5b, 0x17, 0xa6, 0x50, 0x55,
        0xd5, 0x93, 0x92, 0x30, 0xd7, 0x7a, 0x3b, 0xd4, 0x7c, 0x5d, 0xbd, 0x1e, 0x78, 0xd6, 0xd2, 0xc7,
        0xc1, 0x84, 0xd3, 0xbd, 0x4e, 0x7f, 0xb8, 0x92, 0x7d, 0xb6, 0xe6, 0xec, 0x61, 0xd8, 0x17, 0x96,
        0xbd, 0x31, 0xfb, 0xdb, 0xb6, 0xac, 0x58, 0xdf, 0x69, 0x43, 0xc8, 0xa8, 0xca, 0xcf, 0x03, 0x08,
        0xf4, 0x6f, 0x28, 0xb8, 0xff, 0x97, 0x5a, 0x7d, 0x73, 0x31, 0xdb, 0xb3, 0x62, 0xd4, 0x07, 0x36,
        0x40, 0x3c, 0x5d, 0x65, 0x97, 0xa5, 0x4f, 0xd1, 0xda, 0xd9, 0x15, 0x34, 0xbe, 0x98, 0xc8, 0x0a,
        0x33, 0x74, 0x14, 0x13, 0x81, 0x4c, 0x51, 0xd0, 0xee, 0xe4, 0xfa, 0x56, 0x60, 0xc4, 0x2f, 0x7c,
        0xa6, 0xa9, 0xdd, 0x0a, 0x11, 0x10, 0xbd, 0xf4, 0x98, 0xb1, 0xf1, 0xc9, 0xf8, 0x1e, 0x74, 0x31,
        0xbd, 0xd6, 0xce, 0x91, 0xd0, 0xab, 0xdb, 0x1e, 0xc9, 0x3f, 0x03, 0x40, 0x94, 0x7a, 0x6e, 0x6b,
        0xf0, 0x4c, 0x78, 0xdf, 0x46, 0x31, 0x63, 0xc3, 0xb3, 0x20, 0x8d, 0xa2, 0x39, 0x35, 0x4e, 0x6a,
        0xd9, 0xa7, 0x8d, 0x9f, 0xce, 0x9d, 0xa4, 0x60, 0x42, 0x13, 0x77, 0x91, 0x52, 0x4d, 0x45, 0xbf,
        0xc8, 0x46, 0x96, 0xb8, 0x7c, 0x0a, 0x7b, 0x2c, 0xfa, 0xdf, 0x39, 0x43, 0xce, 0x86, 0xdd, 0xe9,
      },
      // Used to encrypt PKG digest at 0x1000
      new byte[]
      {
        0xd2, 0x12, 0xfc, 0x33, 0x5f, 0x6d, 0xdb, 0x83, 0x16, 0x09, 0x62, 0x8b, 0x03, 0x56, 0x27, 0x37,
        0x82, 0xd4, 0x77, 0x85, 0x35, 0x29, 0x39, 0x2d, 0x52, 0x6b, 0x8c, 0x4c, 0x8c, 0xfb, 0x06, 0xc1,
        0x84, 0x5b, 0xe7, 0xd4, 0xf7, 0xbc, 0xd2, 0x4e, 0x62, 0x45, 0xcd, 0x2a, 0xbb, 0xd7, 0x77, 0x76,
        0x45, 0x36, 0x55, 0x27, 0x3f, 0xb3, 0xf5, 0xf9, 0x8e, 0xda, 0x4b, 0xef, 0xaa, 0x59, 0xae, 0xb3,
        0x9b, 0xea, 0x54, 0x98, 0xd2, 0x06, 0x32, 0x6a, 0x58, 0x31, 0x2a, 0xe0, 0xd4, 0x4f, 0x90, 0xb5,
        0x0a, 0x7d, 0xec, 0xf4, 0x3a, 0x9c, 0x52, 0x67, 0x2d, 0x99, 0x31, 0x8e, 0x0c, 0x43, 0xe6, 0x82,
        0xfe, 0x07, 0x46, 0xe1, 0x2e, 0x50, 0xd4, 0x1f, 0x2d, 0x2f, 0x7e, 0xd9, 0x08, 0xba, 0x06, 0xb3,
        0xbf, 0x2e, 0x20, 0x3f, 0x4e, 0x3f, 0xfe, 0x44, 0xff, 0xaa, 0x50, 0x43, 0x57, 0x91, 0x69, 0x94,
        0x49, 0x15, 0x82, 0x82, 0xe4, 0x0f, 0x4c, 0x8d, 0x9d, 0x2c, 0xc9, 0x5b, 0x1d, 0x64, 0xbf, 0x88,
        0x8b, 0xd4, 0xc5, 0x94, 0xe7, 0x65, 0x47, 0x84, 0x1e, 0xe5, 0x79, 0x10, 0xfb, 0x98, 0x93, 0x47,
        0xb9, 0x7d, 0x85, 0x12, 0xa6, 0x40, 0x98, 0x2c, 0xf7, 0x92, 0xbc, 0x95, 0x19, 0x32, 0xed, 0xe8,
        0x90, 0x56, 0x0d, 0x65, 0xc1, 0xaa, 0x78, 0xc6, 0x2e, 0x54, 0xfd, 0x5f, 0x54, 0xa1, 0xf6, 0x7e,
        0xe5, 0xe0, 0x5f, 0x61, 0xc1, 0x20, 0xb4, 0xb9, 0xb4, 0x33, 0x08, 0x70, 0xe4, 0xdf, 0x89, 0x56,
        0xed, 0x01, 0x29, 0x46, 0x77, 0x5f, 0x8c, 0xb8, 0xa9, 0xf5, 0x1e, 0x2e, 0xb3, 0xb9, 0xbf, 0xe0,
        0x09, 0xb7, 0x8d, 0x28, 0xd4, 0xa6, 0xc3, 0xb8, 0x1e, 0x1f, 0x07, 0xeb, 0xb4, 0x12, 0x0b, 0x95,
        0xb8, 0x85, 0x30, 0xfd, 0xdc, 0x39, 0x13, 0xd0, 0x7c, 0xdc, 0x8f, 0xed, 0xf9, 0xc9, 0xa3, 0xc1,
      },
      new byte[]
      {
        0xc9, 0xb2, 0x40, 0x2b, 0x79, 0x55, 0x6a, 0xf9, 0x60, 0x5e, 0x09, 0x86, 0x44, 0xe8, 0x65, 0x57,
        0x9f, 0x3d, 0xf6, 0xf4, 0x80, 0x0d, 0x23, 0x0c, 0xd5, 0xee, 0x4b, 0xc1, 0x8d, 0x5a, 0x78, 0x2a,
        0x94, 0x22, 0x4f, 0xd9, 0x95, 0x9d, 0x86, 0x3d, 0x48, 0xb3, 0xb9, 0x7c, 0x6f, 0xb8, 0x93, 0x9f,
        0xff, 0xcc, 0xc3, 0x90, 0x19, 0xa4, 0x64, 0x95, 0x9e, 0x6b, 0xda, 0x17, 0x24, 0x0b, 0xe0, 0xac,
        0xf6, 0xb2, 0xbb, 0xbe, 0x1c, 0xcc, 0xa2, 0xe3, 0x77, 0xfb, 0x41, 0x0c, 0xdc, 0xe3, 0x38, 0x9e,
        0x86, 0xa2, 0x6f, 0xe5, 0xa6, 0x7d, 0x96, 0x94, 0xbe, 0xff, 0xc7, 0x6f, 0xce, 0x4c, 0x82, 0x9b,
        0x67, 0x91, 0x08, 0xb2, 0xc3, 0xb4, 0x72, 0xf4, 0xad, 0x2f, 0x4c, 0x4c, 0xa3, 0xf4, 0xc9, 0x71,
        0x2e, 0x3a, 0xcc, 0x1e, 0x50, 0xd1, 0x99, 0x41, 0xc5, 0x50, 0x97, 0xb4, 0x10, 0x04, 0xe8, 0xab,
        0x4e, 0x2b, 0x89, 0x7c, 0xa8, 0xe1, 0xbf, 0xea, 0x7f, 0xac, 0x3c, 0x15, 0xe5, 0xb2, 0x39, 0x4c,
        0x44, 0x9d, 0x82, 0x36, 0x74, 0xbf, 0x0a, 0x84, 0x23, 0x2b, 0xca, 0xbf, 0x01, 0x19, 0x3f, 0x52,
        0x06, 0xfb, 0x5a, 0xac, 0x28, 0xc6, 0x8f, 0xbf, 0x70, 0x05, 0x70, 0x33, 0xb4, 0xe6, 0xcc, 0x85,
        0x4e, 0x54, 0xcd, 0x18, 0x1c, 0x38, 0x00, 0x58, 0x05, 0x61, 0x92, 0xc9, 0x45, 0xa9, 0x72, 0xf0,
        0x69, 0x00, 0x89, 0xbc, 0xb2, 0x34, 0x2b, 0x79, 0xf6, 0x8f, 0x53, 0x6e, 0x80, 0x50, 0xc3, 0x83,
        0x88, 0xe7, 0x36, 0x83, 0x8c, 0x7d, 0xdf, 0x67, 0x43, 0x3f, 0x56, 0x78, 0x52, 0x7c, 0x09, 0xab,
        0xac, 0x80, 0xc5, 0x84, 0x98, 0x71, 0x61, 0x16, 0xd7, 0x8c, 0x05, 0xe0, 0x03, 0xe1, 0xcc, 0xba,
        0xa7, 0xa7, 0x41, 0x6d, 0x35, 0x48, 0x7c, 0xa0, 0x6d, 0x5b, 0x9e, 0xc2, 0xd2, 0x43, 0x95, 0xc7,
      },
      new byte[]
      {
        0xe3, 0x56, 0xf1, 0x6b, 0x5d, 0xff, 0x3c, 0x7d, 0xff, 0x42, 0xe7, 0x9a, 0x32, 0xc1, 0x44, 0xe8,
        0x3b, 0xde, 0x58, 0xdf, 0x19, 0xbb, 0x9c, 0x4a, 0x0f, 0x5a, 0xff, 0x15, 0x39, 0x02, 0xde, 0x76,
        0x65, 0xbf, 0x2a, 0x71, 0x62, 0xee, 0x0d, 0x34, 0xa2, 0x8d, 0x73, 0x71, 0x83, 0x93, 0xea, 0x05,
        0x91, 0x23, 0x17, 0x43, 0xc8, 0x06, 0x38, 0x1a, 0x95, 0xe5, 0x80, 0x6a, 0xd0, 0xac, 0xdd, 0x8c,
        0x91, 0xfb, 0x1f, 0xd7, 0xa2, 0x1a, 0x69, 0x3d, 0x03, 0x7c, 0xdd, 0x8e, 0x2d, 0xb0, 0xb2, 0x4c,
        0xc4, 0xab, 0x73, 0xce, 0x65, 0xa1, 0xa3, 0xe6, 0x53, 0x63, 0x41, 0x92, 0x0b, 0x6e, 0x08, 0x77,
        0x77, 0x2b, 0x97, 0x62, 0xc8, 0x01, 0xdf, 0x3c, 0x4b, 0x9a, 0x39, 0x2c, 0xd2, 0xab, 0xde, 0x7d,
        0x27, 0xe7, 0xa7, 0x6a, 0x99, 0x7d, 0xa3, 0x9e, 0x6e, 0x5a, 0x2b, 0xaf, 0x17, 0x23, 0x74, 0xf0,
        0xe6, 0xf7, 0xd0, 0x7e, 0x1a, 0xf7, 0x39, 0x4b, 0xb7, 0x9d, 0xba, 0x81, 0x3a, 0xf6, 0x75, 0x7e,
        0x02, 0x0a, 0x1b, 0x86, 0xf7, 0x04, 0x65, 0xb7, 0x57, 0x1d, 0x50, 0xc9, 0x82, 0x34, 0x8f, 0x54,
        0x61, 0x0c, 0x0a, 0x4b, 0xb8, 0x47, 0x9f, 0xfc, 0xac, 0xc4, 0x0f, 0x18, 0xbc, 0x3e, 0x80, 0xbd,
        0xdf, 0xa9, 0x2d, 0xc8, 0x8c, 0x89, 0xa7, 0xdf, 0x55, 0x66, 0xc2, 0xb0, 0xee, 0x5a, 0x23, 0x86,
        0x00, 0xea, 0xa4, 0x85, 0x19, 0x30, 0xec, 0xe8, 0x6c, 0x0b, 0x30, 0x2e, 0x3e, 0x6b, 0xaa, 0xc8,
        0xd0, 0x18, 0x5a, 0xc0, 0x49, 0x00, 0x2b, 0x3a, 0xbc, 0x75, 0x4c, 0xd3, 0x58, 0x6a, 0x76, 0x42,
        0x4f, 0xc4, 0x5a, 0xb1, 0xd1, 0xd7, 0x27, 0x11, 0xfd, 0x5b, 0x4c, 0xb7, 0x93, 0x70, 0x82, 0x99,
        0xde, 0x23, 0xf2, 0xc3, 0xde, 0x09, 0x6c, 0x2b, 0xa7, 0xf2, 0x64, 0xbf, 0x95, 0x48, 0x9c, 0xd1,
      },
      new byte[]
      {
        0xe9, 0xca, 0xc3, 0x44, 0xb4, 0xd9, 0x6a, 0x2c, 0x5c, 0x25, 0x5d, 0xf0, 0xf1, 0x84, 0x8c, 0x80,
        0x0d, 0x55, 0xf8, 0x7e, 0x26, 0x32, 0x6c, 0x3b, 0x0c, 0x1a, 0x14, 0x46, 0x2d, 0x5f, 0xd0, 0x57,
        0xd4, 0xa0, 0xb8, 0x7c, 0x8b, 0xb6, 0x88, 0x0b, 0xa9, 0xd3, 0xac, 0x28, 0x2c, 0x38, 0xc0, 0x6d,
        0x0a, 0x30, 0xfe, 0x80, 0xd7, 0x1a, 0xb4, 0x81, 0xd6, 0xa1, 0x76, 0x22, 0x19, 0x8d, 0xb0, 0x4c,
        0xc3, 0x0f, 0x23, 0x38, 0x2b, 0x1b, 0xa1, 0x2b, 0x1b, 0xcb, 0x7e, 0xe0, 0xc5, 0xfc, 0x79, 0x96,
        0x0a, 0x53, 0x7a, 0x11, 0xb3, 0x23, 0x04, 0x71, 0xe6, 0x3f, 0x2c, 0xae, 0xed, 0xd5, 0x49, 0xb3,
        0x25, 0x5f, 0xda, 0x80, 0x7a, 0xf1, 0xaf, 0x91, 0xdb, 0x17, 0x70, 0xa5, 0x22, 0x1c, 0x5c, 0xaf,
        0xe6, 0x06, 0xcd, 0xe2, 0x11, 0x8f, 0x68, 0x42, 0xe7, 0x94, 0x2d, 0x8f, 0x25, 0xd2, 0x3c, 0xc4,
        0xaf, 0x98, 0x67, 0x9f, 0xcf, 0x16, 0xbe, 0x70, 0x1e, 0x79, 0xb8, 0xc8, 0x1f, 0x70, 0x46, 0x49,
        0x39, 0x06, 0xa1, 0xff, 0x9e, 0x01, 0x1e, 0xc0, 0xcf, 0x1d, 0xc8, 0x04, 0x80, 0x61, 0xc2, 0x2c,
        0x78, 0x69, 0xb2, 0x3b, 0x4d, 0xa2, 0x0f, 0xdb, 0xb7, 0x64, 0xb4, 0x65, 0xba, 0xae, 0x2f, 0xc6,
        0x9b, 0x09, 0xfb, 0x6e, 0x49, 0x7c, 0xe1, 0xa0, 0x18, 0x2d, 0x66, 0x62, 0xab, 0xde, 0xc3, 0xc9,
        0x60, 0xfa, 0x67, 0xf3, 0x50, 0x55, 0x26, 0xae, 0x0f, 0xb5, 0xe0, 0xcd, 0xd3, 0xd9, 0xb6, 0x73,
        0xe2, 0x99, 0xa6, 0xe1, 0xba, 0xdd, 0x47, 0x8d, 0x54, 0x65, 0x12, 0xeb, 0xe9, 0x24, 0xff, 0x26,
        0xc2, 0xb8, 0xaf, 0x07, 0x92, 0x1a, 0x3b, 0x12, 0x31, 0x71, 0x13, 0x03, 0x63, 0xd0, 0xa6, 0x31,
        0x4d, 0x55, 0x95, 0x99, 0x21, 0x4c, 0xec, 0x48, 0xfd, 0x09, 0xe0, 0x75, 0x85, 0x46, 0x5b, 0x85,
      }
        };

        public static byte[] PkgSignKey => PkgPublicKeys[3];
    }
}