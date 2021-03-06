//
// NAntContrib
// Copyright (C) 2001-2005 Gerry Shaw
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307 USA
//
// Gert Driesen (drieseng@users.sourceforge.net)

namespace NAnt.Contrib.Types.BizTalk {
    /// <summary>
    /// Indicates the status of a service.
    /// </summary>
    public enum ServiceStatus {
        /// <summary>
        /// The service is unbound.
        /// </summary>
        Unbound = 1,

        /// <summary>
        /// The service is bound.
        /// </summary>
        Bound = 2,

        /// <summary>
        /// The service is enlisted, but not started.
        /// </summary>
        Stopped = 3,

        /// <summary>
        /// The service is started.
        /// </summary>
        Started = 4
    }
}
