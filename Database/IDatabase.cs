/**************************************************************************
 *                                                                        *
 *  File:        IDatabase.cs                                             *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: Interfata pentru persistenta datelor.                    *
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
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    /// <summary>
    /// Interfata pentru persistenta datelor.
    /// Clasa ce o implementeaza, trebuie sa implementeze si metodele ExecuteQuery si ExecuteNonQuery.
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Metoda ce executa un query catre baza de date / metoda de persistenta a datelor alese si returneaza date (ex. SELECT in SQL).
        /// </summary>
        /// <param name="query">Query-ul ce se doreste a se executa.</param>
        /// <returns>Returneaza DataTable.</returns>
        DataTable ExecuteQuery(string query);

        /// <summary>
        /// Metoda ce executa un query catre baza de date / metoda de persistenta a datelor alese si returneaza NUMARUL de randuri/date modificate.
        /// ex. UPDATE, INSERT, DELETE.
        /// </summary>
        /// <param name="query">Quer-ul ce se doreste a se executa.</param>
        /// <returns>Numarul de randuri/date modificate.</returns>
        int ExecuteNonQuery(string query);
    }
}
