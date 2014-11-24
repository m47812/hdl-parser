//
//  Copyright (C) 2010-2014  Denis Gavrish
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;

namespace VHDL.expression
{
    using SubtypeIndication = VHDL.type.ISubtypeIndication;

    /// <summary>
    /// Allocator with subtype indication parameter.
    /// </summary>
    [Serializable]
    public class SubtypeIndicationAllocator : Primary
    {
        private SubtypeIndication type;

        /// <summary>
        /// Creates a subtype indication allocator.
        /// </summary>
        /// <param name="type"></param>
        public SubtypeIndicationAllocator(SubtypeIndication type)
        {
            this.type = type;
        }

        /// <summary>
        /// Returns the type.
        /// </summary>
        public override SubtypeIndication Type
        {
            get { return type; }
        }


        public override Choice copy()
        {
            //TODO: copy subtype indication
            return new SubtypeIndicationAllocator(type);
        }

        public override void accept(ExpressionVisitor visitor)
        {
            visitor.visitSubtypeIndicationAllocator(this);
        }
    }
}