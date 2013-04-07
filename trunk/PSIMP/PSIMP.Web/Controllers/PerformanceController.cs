﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSIMP.Web.Controllers
{
    public class PerformanceController : Controller
    {
        //
        // GET: /Performance/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PerformanceUI()
        {
            return View();
        }

        public ActionResult GanttData()
        {
            return Content(GanttTestData.GetData());
        }
    }

    public class GanttTestData
    {
        public static string GetData()
        {
            return @"
<chart showTaskNames='1' dateFormat='dd/mm/yyyy' hoverCapBgColor='FFFFFF' hoverCapBorderColor='333333' ganttLineColor='99CC00' ganttLineAlpha='20' baseFontColor='333333' gridBorderColor='99CC00' taskBarRoundRadius='4' showShadow='0'>
	<categories  bgColor='333333' fontColor='99cc00' isBold='1' fontSize='14' >
		<category start='1/9/2005' end='31/12/2005' name='2005' />
		<category start='1/1/2006' end='31/7/2006' name='2006' />
	</categories>
	<categories  bgColor='99cc00' bgAlpha='40' fontColor='333333' align='center' fontSize='10' isBold='1'>
		<category start='1/9/2005' end='30/9/2005' name='Sep' />
		<category start='1/10/2005' end='31/10/2005' name='Oct' />
		<category start='1/11/2005' end='30/11/2005' name='Nov' />
		<category start='1/12/2005' end='31/12/2005' name='Dec' />
		<category start='1/1/2006' end='31/1/2006' name='Jan' />
		<category start='1/2/2006' end='28/2/2006' name='Feb' />
		<category start='1/3/2006' end='31/3/2006' name='March' />
		<category start='1/4/2006' end='30/4/2006' name='Apr'  />
		<category start='1/5/2006' end='31/5/2006' name='May' />
		<category start='1/6/2006' end='30/6/2006' name='June' />
		<category start='1/7/2006' end='31/7/2006' name='July' />
	</categories>
	<processes positionInGrid='right' align='center' headerText=' Leader  ' fontColor='333333' fontSize='11' isBold='1' isAnimated='1' bgColor='99cc00' headerbgColor='333333' headerFontColor='99CC00' headerFontSize='16' bgAlpha='40'>
		<process Name='Mark' id='1' />
		<process Name='Tom' id='2' />
		<process Name='David' id='3' />
		<process Name='Alan' id='4' />
		<process Name='Adam' id='5' />
		<process Name='Peter' id='6' />
	</processes>
	<tasks  width='10' >
		<task name='Survey' hoverText='Market Survey' processId='1' start='7/9/2005' end='10/10/2005' id='Srvy' color='99cc00' alpha='60' topPadding='19' />
 		<task name='Concept' hoverText= 'Develop Concept for Product' processId='1' start='25/10/2005' end='9/11/2005' id='Cpt1' color='99cc00' alpha='60'  />
	 	<task name='Concept' showName='0' hoverText= 'Develop Concept for Product' processId='2' start='25/10/2005' end='9/11/2005' id='Cpt2' color='99cc00' alpha='60'  />
		<task name='Design' hoverText= 'Preliminary Design' processId='2' start='12/11/2005' end='25/11/2005' id='Desn' color='99cc00' alpha='60'/>
		<task name='Product Development' processId='2' start='6/12/2005' end='2/3/2006' id='PD1' color='99cc00' alpha='60'/>
		<task name='Product Development' processId='3' start='6/12/2005' end='2/3/2006' id='PD2' color='99cc00' alpha='60' />
		<task name='Doc Outline' hoverText='Documentation Outline' processId='2' start='6/4/2006' end='1/5/2006' id='DocOut' color='99cc00' alpha='60'/>
		<task name='Alpha' hoverText='Alpha Release' processId='4' start='15/3/2006' end='2/4/2006' id='alpha' color='99cc00' alpha='60'/>
		<task name='Beta' hoverText='Beta Release' processId='3' start='10/5/2006' end='2/6/2006' id='Beta' color='99cc00' alpha='60'/>
		<task name='Doc.' hoverText='Documentation' processId='4' start='12/5/2006' end='29/5/2006' id='Doc' color='99cc00' alpha='60'/>
		<task name='Website Design' hoverText='Website Design' processId='5' start='18/5/2006' end='22/6/2006' id='Web' color='99cc00' alpha='60'/>
		<task name='Release' hoverText='Product Release' processId='6' start='5/7/2006' end='29/7/2006' id='Rls' color='99cc00' alpha='60'/>
		<task name='Dvlp' hoverText='Development on Beta Feedback' processId='3' start='10/6/2006' end='1/7/2006' id='Dvlp' color='99cc00' alpha='60'/>
		<task name='QA' hoverText='QA Testing' processId='4' start='9/4/2006' end='22/4/2006' id='QA1' color='99cc00' alpha='60'/>
  		<task name='QA2' hoverText='QA Testing-Phase 2' processId='4' start='25/6/2006' end='5/7/2006' id='QA2' color='99cc00' alpha='60'/>
	</tasks>
	<connectors color='99cc00' thickness='2' >
		<connector fromTaskId='Cpt1' toTaskId='Cpt2' fromTaskConnectStart='1'/>
		<connector fromTaskId='PD1' toTaskId='PD2' fromTaskConnectStart='1'/>
		<connector fromTaskId='PD1' toTaskId='alpha' />
		<connector fromTaskId='PD2' toTaskId='alpha' />
		<connector fromTaskId='DocOut' toTaskId='Doc' />
		<connector fromTaskId='QA1' toTaskId='beta' />
		<connector fromTaskId='Dvlp' toTaskId='QA2' />
		<connector fromTaskId='QA2' toTaskId='Rls' />
	</connectors>
	<milestones>
		<milestone date='29/7/2006' taskId='Rls' radius='10' color='333333' shape='Star' numSides='5' borderThickness='1'/>
		<milestone date='2/3/2006' taskId='PD1' radius='10' color='333333' shape='Star' numSides='5' borderThickness='1' />
		<milestone date='2/3/2006' taskId='PD2' radius='10' color='333333' shape='Star' numSides='5' borderThickness='1'/>
	</milestones>	
</chart>";
        }
    }
}
