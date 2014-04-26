﻿/*
 * Copyright 2009 The Closure Compiler Authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace ClosureSourceMaps
{
    /// <summary>
    /// Represents a position in a source file
    /// </summary>
    public class FilePosition
    {
        private readonly int line;
        private readonly int column;

        public FilePosition(int line, int column) 
        {
            this.line = line;
            this.column = column;
        }

        /// <summary>
        /// Returns the line number of this position.
        /// Note: The v1 and v2 source maps use a line number with the first line
        /// being 1, whereas the v3 source map corrects this and uses a first line
        /// number of 0 to be consistent with the column representation.
        /// </summary>
        public int Line
        {
            get
            {
                return line;
            }
        }

        /// <summary>
        /// return the character index on the line
        /// of this position, with the first column being 0
        /// </summary>
        public int Column
        {
            get
            {
                return column;
            }
        }
    }
}
