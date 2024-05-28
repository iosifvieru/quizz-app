/**************************************************************************
 *                                                                        *
 *  File:        IEncrypt.cs                                              *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: Interfata pentru criptarea datelor                       *
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
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    /// <summary>
    /// Interfata pentru criptare.
    /// </summary>
    public interface IEncrypt
    {
        /// <summary>
        /// Metoda ce primeste un string si-l returneaza criptat.
        /// </summary>
        /// <param name="input">Un sir de caractere.</param>
        /// <returns>Returneaza sirul criptat.</returns>
        string Encrypt(string input);

        /// <summary>
        /// Metoda ce primeste un string si-l decripteaza.
        /// </summary>
        /// <param name="input">Un sir de caractere.</param>
        /// <returns>Returneaza sirul decriptat.</returns>
        string Decrypt(string input);

        /// <summary>
        /// Metoda ce primeste un string si-l hashuieste.
        /// </summary>
        /// <param name="input">Un sir de caractere.</param>
        /// <returns>Returneaza sirul hashuit.</returns>
        string Hash(string input);
    }
}
