/**************************************************************************
 *                                                                        *
 *  File:        SHA256Hashing.cs                                         *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: Clasa ce foloseste SHA256 pt. a hashui date.             *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    /// <summary>
    /// Implementeaza clasa IEncrpyt.
    /// </summary>
    public class SHA256Hashing: IEncrypt
    {

        public SHA256Hashing() { }

        /// <summary>
        /// Metoda implementata "dummy"
        /// </summary>
        /// <param name="input">Nu este implementata.</param>
        /// <returns>Nu este implementata.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string Decrypt(string input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda implementata "dummy"
        /// </summary>
        /// <param name="input">Nu este implementata.</param>
        /// <returns>Nu este implementata.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string Encrypt(string input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda ce primeste un sir de caractere si-l hashuieste folosind alg. SHA256
        /// </summary>
        /// <param name="input">Un sir de caractere</param>
        /// <returns>Un hash al sirului de intrare.</returns>
        public string Hash(string input)
        {
            // linia de mai jos creaza un obiect SHA256 din libraria System.Security.Cryptography
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // se calculeaza propriu zis hash-ul stringului de input
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // converteste din byte[] in string.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
