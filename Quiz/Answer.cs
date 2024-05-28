/**************************************************************************
 *                                                                        *
 *  File:        Answer.cs                                                *
 *  Copyright:   (c) 2024, Vieru Iosif,                                   *
 *                         Georgita Adrian,                               *
 *                         Talida Caraman,                                *
 *                         Pricop Matei-Ioan                              *
 *  E-mail:      iosif.vieru@student.tuiasi.ro,                           *
 *               adrian.georgita@student.tuiasi.ro,                       *
 *               talida.caraman@student.tuiasi.ro,                        *
 *               matei-ioan.pricop@student.tuiasi.ro                      *
 *  Description: Clasa ce repr. raspunsul unui quiz.                      *
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

namespace proiect_ip.Quiz
{
    public class Answer
    {
        private int _id;
        private String _answer;
        private bool _isCorrect;

        /// <summary>
        /// Constructorul clasei <class>Answer</class>
        /// </summary>
        /// <param name="id">ID-ul raspunsului</param>
        /// <param name="answer">Textul raspunsului</param>
        /// <param name="isCorrect">Flag-ul care indica daca raspunsul este corect</param>
        public Answer(int id, string answer, bool isCorrect = false)
        {
            _id = id;
            _answer = answer;
            _isCorrect = isCorrect;
        }

        /// <summary>
        /// Obtine textul raspunsului
        /// </summary>
        public String GetAnswerText { get => _answer; }
        /// <summary>
        /// Seteaza textul raspunsului
        /// </summary>
        public String SetAnswerText { set => _answer = value; }

        /// <summary>
        /// Obtine ID-ul raspunsului
        /// </summary>
        public int ID { get => _id; }
        /// <summary>
        /// Obtine / Seteaza flag-ul care indica daca raspunsul este corect.
        /// </summary>
        public bool IsCorrect {
            get => _isCorrect;
            set => _isCorrect = value;
        }
    }
}
