﻿/*<copyright>
Mo+ Solution Builder is a model oriented programming language and IDE, used for building models and generating code and other documents in a model driven development process.

Copyright (C) 2013 Dave Clemmer, Intelligent Coding Solutions, LLC

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.
</copyright>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoPlus.Interpreter.BLL.Interpreter
{
	///--------------------------------------------------------------------------------
	/// <summary>This class bumps line numbers for each node in the tree.</summary>
	///
	/// <CreatedByUserName>DAVE\JavaDave</CreatedByUserName>
	/// <CreatedDate>3/29/2013</CreatedDate>
	/// <Status>Customized</Status>
	///--------------------------------------------------------------------------------
	public class IncrementLineNumberVisitor : IGrammarNodeVisitor
	{
		///--------------------------------------------------------------------------------
		/// <summary>This method performs actions at the beginning of the visit.</summary>
		/// 
		/// <param name="node">The node being visited.</param>
		///--------------------------------------------------------------------------------
		public void BeginVisit(IGrammarNode node)
		{
			node.LineNumber += 1;
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method performs actions at the end of the visit.</summary>
		/// 
		/// <param name="node">The node being visited.</param>
		///--------------------------------------------------------------------------------
		public void EndVisit(IGrammarNode node)
		{
		}
	}
}