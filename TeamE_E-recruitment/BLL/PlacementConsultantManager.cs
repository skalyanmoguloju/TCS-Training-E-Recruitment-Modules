﻿


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: PlacementConsultantManager.cs
Description of the file: Used as Business Logic Layer.
 * This source is subject to the to ABC Public License. 
 * http://www.abc.erecruitment.com/  
 * All other rights reserved.  
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,  EITHER 
 * EXPRESSED  * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED  WARRANTIES OF
 * MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*********************************************************************/ 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using E_Recruitment.Types;
using E_Recruitment.DALFactory;
using E_Recruitment.BOFactory;

namespace E_Recruitment.BLL
{
    public class PlacementConsultantManager : IPlacementConsultantManager
    {
        public List<IPlacementConsultant> ListPlacement()
        {

            IPlacementConsultantDB objPlacementConsultantDB = PlacementConsultantDBFactory.Create_PlacementConsultantDB();
            return objPlacementConsultantDB.getPlacementConsultants();
        }
    }
}
