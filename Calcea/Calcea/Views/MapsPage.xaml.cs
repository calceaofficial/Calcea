﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Calcea.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapsPage : ContentPage
	{
		public MapsPage ()
		{
			InitializeComponent ();

			bool stadJourney = true;

			JourneyMap.RouteCoordinates = new List<Position>();

			if (!stadJourney)
			{
				JourneyMap.RouteCoordinates.Add(new Position(48.12631, -1.64946));
				JourneyMap.RouteCoordinates.Add(new Position(48.12630, -1.64945));
				JourneyMap.RouteCoordinates.Add(new Position(48.12630, -1.64946));
				JourneyMap.RouteCoordinates.Add(new Position(48.12629, -1.64945));
				JourneyMap.RouteCoordinates.Add(new Position(48.12628, -1.64945));
				JourneyMap.RouteCoordinates.Add(new Position(48.12628, -1.64944));
				JourneyMap.RouteCoordinates.Add(new Position(48.12628, -1.64942));
				JourneyMap.RouteCoordinates.Add(new Position(48.12627, -1.64942));
				JourneyMap.RouteCoordinates.Add(new Position(48.12626, -1.64943));
				JourneyMap.RouteCoordinates.Add(new Position(48.12626, -1.64942));
				JourneyMap.RouteCoordinates.Add(new Position(48.12626, -1.64941));
				JourneyMap.RouteCoordinates.Add(new Position(48.12627, -1.64941));
				JourneyMap.RouteCoordinates.Add(new Position(48.12626, -1.64941));
				JourneyMap.RouteCoordinates.Add(new Position(48.12626, -1.64940));
				JourneyMap.RouteCoordinates.Add(new Position(48.12625, -1.64941));
				JourneyMap.RouteCoordinates.Add(new Position(48.12620, -1.64941));
				JourneyMap.RouteCoordinates.Add(new Position(48.12618, -1.64939));
				JourneyMap.RouteCoordinates.Add(new Position(48.12611, -1.64936));
				JourneyMap.RouteCoordinates.Add(new Position(48.12581, -1.64938));
				JourneyMap.RouteCoordinates.Add(new Position(48.12560, -1.64949));
				JourneyMap.RouteCoordinates.Add(new Position(48.12522, -1.64956));
				JourneyMap.RouteCoordinates.Add(new Position(48.12484, -1.64960));
				JourneyMap.RouteCoordinates.Add(new Position(48.12443, -1.64965));
				JourneyMap.RouteCoordinates.Add(new Position(48.12411, -1.64959));
				JourneyMap.RouteCoordinates.Add(new Position(48.12379, -1.64953));
				JourneyMap.RouteCoordinates.Add(new Position(48.12343, -1.64955));
				JourneyMap.RouteCoordinates.Add(new Position(48.12132, -1.65009));
				JourneyMap.RouteCoordinates.Add(new Position(48.12113, -1.65023));
				JourneyMap.RouteCoordinates.Add(new Position(48.12094, -1.65032));
				JourneyMap.RouteCoordinates.Add(new Position(48.12075, -1.65040));
				JourneyMap.RouteCoordinates.Add(new Position(48.12066, -1.65050));
				JourneyMap.RouteCoordinates.Add(new Position(48.12058, -1.65053));
				JourneyMap.RouteCoordinates.Add(new Position(48.12047, -1.65054));
				JourneyMap.RouteCoordinates.Add(new Position(48.12047, -1.65051));
				JourneyMap.RouteCoordinates.Add(new Position(48.12056, -1.65049));
				JourneyMap.RouteCoordinates.Add(new Position(48.12031, -1.65061));
				JourneyMap.RouteCoordinates.Add(new Position(48.12050, -1.65058));
				JourneyMap.RouteCoordinates.Add(new Position(48.12065, -1.65056));
				JourneyMap.RouteCoordinates.Add(new Position(48.12072, -1.65056));
				JourneyMap.RouteCoordinates.Add(new Position(48.12090, -1.65054));
				JourneyMap.RouteCoordinates.Add(new Position(48.12105, -1.65050));
				JourneyMap.RouteCoordinates.Add(new Position(48.12118, -1.65049));
				JourneyMap.RouteCoordinates.Add(new Position(48.12129, -1.65044));
				JourneyMap.RouteCoordinates.Add(new Position(48.12658, -1.64893));
				JourneyMap.RouteCoordinates.Add(new Position(48.12660, -1.64897));
				JourneyMap.RouteCoordinates.Add(new Position(48.12663, -1.64902));
				JourneyMap.RouteCoordinates.Add(new Position(48.12663, -1.64902));
				JourneyMap.RouteCoordinates.Add(new Position(48.12664, -1.64901));
				JourneyMap.RouteCoordinates.Add(new Position(48.12664, -1.64902));
				JourneyMap.RouteCoordinates.Add(new Position(48.12664, -1.64901));
				JourneyMap.RouteCoordinates.Add(new Position(48.12664, -1.64899));
				JourneyMap.RouteCoordinates.Add(new Position(48.12665, -1.64898));
				JourneyMap.RouteCoordinates.Add(new Position(48.12667, -1.64898));
				JourneyMap.RouteCoordinates.Add(new Position(48.12668, -1.64898));
				JourneyMap.RouteCoordinates.Add(new Position(48.12669, -1.64898));
				JourneyMap.RouteCoordinates.Add(new Position(48.12670, -1.64897));
				JourneyMap.RouteCoordinates.Add(new Position(48.12672, -1.64898));
				JourneyMap.RouteCoordinates.Add(new Position(48.12673, -1.64899));
				JourneyMap.RouteCoordinates.Add(new Position(48.12675, -1.64900));
				JourneyMap.RouteCoordinates.Add(new Position(48.12675, -1.64899));
				JourneyMap.RouteCoordinates.Add(new Position(48.12675, -1.64897));
				JourneyMap.RouteCoordinates.Add(new Position(48.12676, -1.64897));
				JourneyMap.RouteCoordinates.Add(new Position(48.12675, -1.64896));
				JourneyMap.RouteCoordinates.Add(new Position(48.12677, -1.64896));
				JourneyMap.RouteCoordinates.Add(new Position(48.12677, -1.64896));
				JourneyMap.RouteCoordinates.Add(new Position(48.12678, -1.64897));
				JourneyMap.RouteCoordinates.Add(new Position(48.12679, -1.64897));
				JourneyMap.RouteCoordinates.Add(new Position(48.12681, -1.64897));
				JourneyMap.RouteCoordinates.Add(new Position(48.12683, -1.64897));
				JourneyMap.RouteCoordinates.Add(new Position(48.12684, -1.64894));
				JourneyMap.RouteCoordinates.Add(new Position(48.12685, -1.64892));
				JourneyMap.RouteCoordinates.Add(new Position(48.12687, -1.64890));
				JourneyMap.RouteCoordinates.Add(new Position(48.12688, -1.64889));
				JourneyMap.RouteCoordinates.Add(new Position(48.12689, -1.64888));
				JourneyMap.RouteCoordinates.Add(new Position(48.12691, -1.64888));
				JourneyMap.RouteCoordinates.Add(new Position(48.12692, -1.64887));
				JourneyMap.RouteCoordinates.Add(new Position(48.12693, -1.64887));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64887));
				JourneyMap.RouteCoordinates.Add(new Position(48.12696, -1.64886));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64886));
				JourneyMap.RouteCoordinates.Add(new Position(48.12713, -1.64878));
				JourneyMap.RouteCoordinates.Add(new Position(48.12712, -1.64874));
				JourneyMap.RouteCoordinates.Add(new Position(48.12709, -1.64873));
				JourneyMap.RouteCoordinates.Add(new Position(48.12708, -1.64871));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64869));
				JourneyMap.RouteCoordinates.Add(new Position(48.12706, -1.64868));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64867));
				JourneyMap.RouteCoordinates.Add(new Position(48.12704, -1.64867));
				JourneyMap.RouteCoordinates.Add(new Position(48.12703, -1.64867));
				JourneyMap.RouteCoordinates.Add(new Position(48.12702, -1.64867));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64866));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64865));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64864));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64861));
				JourneyMap.RouteCoordinates.Add(new Position(48.12700, -1.64859));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64858));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64859));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64860));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64862));
				JourneyMap.RouteCoordinates.Add(new Position(48.12702, -1.64861));
				JourneyMap.RouteCoordinates.Add(new Position(48.12703, -1.64861));
				JourneyMap.RouteCoordinates.Add(new Position(48.12704, -1.64861));
				JourneyMap.RouteCoordinates.Add(new Position(48.12704, -1.64859));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64859));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64858));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64859));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64860));
				JourneyMap.RouteCoordinates.Add(new Position(48.12706, -1.64861));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64860));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64860));
				JourneyMap.RouteCoordinates.Add(new Position(48.12708, -1.64858));
				JourneyMap.RouteCoordinates.Add(new Position(48.12708, -1.64857));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64854));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64852));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64850));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64848));
				JourneyMap.RouteCoordinates.Add(new Position(48.12706, -1.64844));
				JourneyMap.RouteCoordinates.Add(new Position(48.12707, -1.64840));
				JourneyMap.RouteCoordinates.Add(new Position(48.12706, -1.64837));
				JourneyMap.RouteCoordinates.Add(new Position(48.12704, -1.64832));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64836));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64832));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64831));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64829));
				JourneyMap.RouteCoordinates.Add(new Position(48.12704, -1.64827));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64825));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64819));
				JourneyMap.RouteCoordinates.Add(new Position(48.12700, -1.64817));
				JourneyMap.RouteCoordinates.Add(new Position(48.12700, -1.64816));
				JourneyMap.RouteCoordinates.Add(new Position(48.12700, -1.64814));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64801));
				JourneyMap.RouteCoordinates.Add(new Position(48.12700, -1.64799));
				JourneyMap.RouteCoordinates.Add(new Position(48.12700, -1.64799));
				JourneyMap.RouteCoordinates.Add(new Position(48.12700, -1.64800));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64790));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64783));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64779));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64776));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64774));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64772));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64770));
				JourneyMap.RouteCoordinates.Add(new Position(48.12697, -1.64769));
				JourneyMap.RouteCoordinates.Add(new Position(48.12697, -1.64767));
				JourneyMap.RouteCoordinates.Add(new Position(48.12697, -1.64766));
				JourneyMap.RouteCoordinates.Add(new Position(48.12697, -1.64764));
				JourneyMap.RouteCoordinates.Add(new Position(48.12697, -1.64764));
				JourneyMap.RouteCoordinates.Add(new Position(48.12697, -1.64763));
				JourneyMap.RouteCoordinates.Add(new Position(48.12697, -1.64762));
				JourneyMap.RouteCoordinates.Add(new Position(48.12698, -1.64762));
				JourneyMap.RouteCoordinates.Add(new Position(48.12698, -1.64763));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64774));
				JourneyMap.RouteCoordinates.Add(new Position(48.12702, -1.64788));
				JourneyMap.RouteCoordinates.Add(new Position(48.12706, -1.64810));
				JourneyMap.RouteCoordinates.Add(new Position(48.12705, -1.64819));
				JourneyMap.RouteCoordinates.Add(new Position(48.12706, -1.64831));

			}
			else
			{
				JourneyMap.RouteCoordinates.Add(new Position(48.12695, -1.64592));
				JourneyMap.RouteCoordinates.Add(new Position(48.12695, -1.64592));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64592));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64592));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64592));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64592));
				JourneyMap.RouteCoordinates.Add(new Position(48.12693, -1.64593));
				JourneyMap.RouteCoordinates.Add(new Position(48.12692, -1.64592));
				JourneyMap.RouteCoordinates.Add(new Position(48.12690, -1.64592));
				JourneyMap.RouteCoordinates.Add(new Position(48.12688, -1.64591));
				JourneyMap.RouteCoordinates.Add(new Position(48.12687, -1.64591));
				JourneyMap.RouteCoordinates.Add(new Position(48.12686, -1.64591));
				JourneyMap.RouteCoordinates.Add(new Position(48.12684, -1.64591));
				JourneyMap.RouteCoordinates.Add(new Position(48.12683, -1.64591));
				JourneyMap.RouteCoordinates.Add(new Position(48.12681, -1.64591));
				JourneyMap.RouteCoordinates.Add(new Position(48.12680, -1.64590));
				JourneyMap.RouteCoordinates.Add(new Position(48.12678, -1.64590));
				JourneyMap.RouteCoordinates.Add(new Position(48.12677, -1.64590));
				JourneyMap.RouteCoordinates.Add(new Position(48.12676, -1.64590));
				JourneyMap.RouteCoordinates.Add(new Position(48.12674, -1.64589));
				JourneyMap.RouteCoordinates.Add(new Position(48.12673, -1.64589));
				JourneyMap.RouteCoordinates.Add(new Position(48.12672, -1.64589));
				JourneyMap.RouteCoordinates.Add(new Position(48.12670, -1.64587));
				JourneyMap.RouteCoordinates.Add(new Position(48.12668, -1.64587));
				JourneyMap.RouteCoordinates.Add(new Position(48.12667, -1.64586));
				JourneyMap.RouteCoordinates.Add(new Position(48.12666, -1.64586));
				JourneyMap.RouteCoordinates.Add(new Position(48.12664, -1.64585));
				JourneyMap.RouteCoordinates.Add(new Position(48.12663, -1.64584));
				JourneyMap.RouteCoordinates.Add(new Position(48.12661, -1.64584));
				JourneyMap.RouteCoordinates.Add(new Position(48.12659, -1.64583));
				JourneyMap.RouteCoordinates.Add(new Position(48.12657, -1.64583));
				JourneyMap.RouteCoordinates.Add(new Position(48.12656, -1.64583));
				JourneyMap.RouteCoordinates.Add(new Position(48.12654, -1.64584));
				JourneyMap.RouteCoordinates.Add(new Position(48.12652, -1.64583));
				JourneyMap.RouteCoordinates.Add(new Position(48.12650, -1.64584));
				JourneyMap.RouteCoordinates.Add(new Position(48.12648, -1.64584));
				JourneyMap.RouteCoordinates.Add(new Position(48.12647, -1.64584));
				JourneyMap.RouteCoordinates.Add(new Position(48.12645, -1.64585));
				JourneyMap.RouteCoordinates.Add(new Position(48.12643, -1.64585));
				JourneyMap.RouteCoordinates.Add(new Position(48.12641, -1.64585));
				JourneyMap.RouteCoordinates.Add(new Position(48.12639, -1.64585));
				JourneyMap.RouteCoordinates.Add(new Position(48.12638, -1.64585));
				JourneyMap.RouteCoordinates.Add(new Position(48.12636, -1.64585));
				JourneyMap.RouteCoordinates.Add(new Position(48.12635, -1.64585));
				JourneyMap.RouteCoordinates.Add(new Position(48.12633, -1.64586));
				JourneyMap.RouteCoordinates.Add(new Position(48.12631, -1.64586));
				JourneyMap.RouteCoordinates.Add(new Position(48.12629, -1.64587));
				JourneyMap.RouteCoordinates.Add(new Position(48.12627, -1.64587));
				JourneyMap.RouteCoordinates.Add(new Position(48.12625, -1.64587));
				JourneyMap.RouteCoordinates.Add(new Position(48.12614, -1.64589));
				JourneyMap.RouteCoordinates.Add(new Position(48.12611, -1.64581));
				JourneyMap.RouteCoordinates.Add(new Position(48.12602, -1.64574));
				JourneyMap.RouteCoordinates.Add(new Position(48.12599, -1.64569));
				JourneyMap.RouteCoordinates.Add(new Position(48.12599, -1.64565));
				JourneyMap.RouteCoordinates.Add(new Position(48.12601, -1.64558));
				JourneyMap.RouteCoordinates.Add(new Position(48.12601, -1.64555));
				JourneyMap.RouteCoordinates.Add(new Position(48.12600, -1.64553));
				JourneyMap.RouteCoordinates.Add(new Position(48.12601, -1.64549));
				JourneyMap.RouteCoordinates.Add(new Position(48.12603, -1.64545));
				JourneyMap.RouteCoordinates.Add(new Position(48.12605, -1.64542));
				JourneyMap.RouteCoordinates.Add(new Position(48.12606, -1.64539));
				JourneyMap.RouteCoordinates.Add(new Position(48.12607, -1.64537));
				JourneyMap.RouteCoordinates.Add(new Position(48.12608, -1.64534));
				JourneyMap.RouteCoordinates.Add(new Position(48.12610, -1.64531));
				JourneyMap.RouteCoordinates.Add(new Position(48.12611, -1.64529));
				JourneyMap.RouteCoordinates.Add(new Position(48.12613, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12616, -1.64527));
				JourneyMap.RouteCoordinates.Add(new Position(48.12619, -1.64527));
				JourneyMap.RouteCoordinates.Add(new Position(48.12622, -1.64527));
				JourneyMap.RouteCoordinates.Add(new Position(48.12625, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12627, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12630, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12632, -1.64529));
				JourneyMap.RouteCoordinates.Add(new Position(48.12635, -1.64529));
				JourneyMap.RouteCoordinates.Add(new Position(48.12638, -1.64529));
				JourneyMap.RouteCoordinates.Add(new Position(48.12640, -1.64529));
				JourneyMap.RouteCoordinates.Add(new Position(48.12642, -1.64529));
				JourneyMap.RouteCoordinates.Add(new Position(48.12645, -1.64529));
				JourneyMap.RouteCoordinates.Add(new Position(48.12647, -1.64529));
				JourneyMap.RouteCoordinates.Add(new Position(48.12649, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12652, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12654, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12655, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12649, -1.64533));
				JourneyMap.RouteCoordinates.Add(new Position(48.12656, -1.64524));
				JourneyMap.RouteCoordinates.Add(new Position(48.12660, -1.64525));
				JourneyMap.RouteCoordinates.Add(new Position(48.12662, -1.64526));
				JourneyMap.RouteCoordinates.Add(new Position(48.12664, -1.64525));
				JourneyMap.RouteCoordinates.Add(new Position(48.12665, -1.64525));
				JourneyMap.RouteCoordinates.Add(new Position(48.12668, -1.64528));
				JourneyMap.RouteCoordinates.Add(new Position(48.12670, -1.64531));
				JourneyMap.RouteCoordinates.Add(new Position(48.12672, -1.64533));
				JourneyMap.RouteCoordinates.Add(new Position(48.12674, -1.64536));
				JourneyMap.RouteCoordinates.Add(new Position(48.12676, -1.64538));
				JourneyMap.RouteCoordinates.Add(new Position(48.12678, -1.64540));
				JourneyMap.RouteCoordinates.Add(new Position(48.12680, -1.64543));
				JourneyMap.RouteCoordinates.Add(new Position(48.12681, -1.64546));
				JourneyMap.RouteCoordinates.Add(new Position(48.12682, -1.64549));
				JourneyMap.RouteCoordinates.Add(new Position(48.12683, -1.64553));
				JourneyMap.RouteCoordinates.Add(new Position(48.12683, -1.64556));
				JourneyMap.RouteCoordinates.Add(new Position(48.12683, -1.64559));
				JourneyMap.RouteCoordinates.Add(new Position(48.12685, -1.64564));
				JourneyMap.RouteCoordinates.Add(new Position(48.12685, -1.64567));
				JourneyMap.RouteCoordinates.Add(new Position(48.12686, -1.64571));
				JourneyMap.RouteCoordinates.Add(new Position(48.12686, -1.64574));
				JourneyMap.RouteCoordinates.Add(new Position(48.12685, -1.64578));
				JourneyMap.RouteCoordinates.Add(new Position(48.12685, -1.64581));
				JourneyMap.RouteCoordinates.Add(new Position(48.12685, -1.64584));
				JourneyMap.RouteCoordinates.Add(new Position(48.12686, -1.64586));
				JourneyMap.RouteCoordinates.Add(new Position(48.12687, -1.64588));
				JourneyMap.RouteCoordinates.Add(new Position(48.12688, -1.64590));
				JourneyMap.RouteCoordinates.Add(new Position(48.12689, -1.64591));
				JourneyMap.RouteCoordinates.Add(new Position(48.12690, -1.64593));
				JourneyMap.RouteCoordinates.Add(new Position(48.12690, -1.64594));
				JourneyMap.RouteCoordinates.Add(new Position(48.12690, -1.64595));
				JourneyMap.RouteCoordinates.Add(new Position(48.12690, -1.64596));
				JourneyMap.RouteCoordinates.Add(new Position(48.12691, -1.64598));
				JourneyMap.RouteCoordinates.Add(new Position(48.12691, -1.64599));
				JourneyMap.RouteCoordinates.Add(new Position(48.12691, -1.64601));
				JourneyMap.RouteCoordinates.Add(new Position(48.12691, -1.64602));
				JourneyMap.RouteCoordinates.Add(new Position(48.12691, -1.64603));
				JourneyMap.RouteCoordinates.Add(new Position(48.12692, -1.64605));
				JourneyMap.RouteCoordinates.Add(new Position(48.12692, -1.64607));
				JourneyMap.RouteCoordinates.Add(new Position(48.12692, -1.64608));
				JourneyMap.RouteCoordinates.Add(new Position(48.12693, -1.64611));
				JourneyMap.RouteCoordinates.Add(new Position(48.12693, -1.64614));
				JourneyMap.RouteCoordinates.Add(new Position(48.12693, -1.64617));
				JourneyMap.RouteCoordinates.Add(new Position(48.12693, -1.64620));
				JourneyMap.RouteCoordinates.Add(new Position(48.12693, -1.64623));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64625));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64628));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64631));
				JourneyMap.RouteCoordinates.Add(new Position(48.12695, -1.64634));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64636));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64639));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64642));
				JourneyMap.RouteCoordinates.Add(new Position(48.12695, -1.64644));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64647));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64649));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64651));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64654));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64656));
				JourneyMap.RouteCoordinates.Add(new Position(48.12694, -1.64659));
				JourneyMap.RouteCoordinates.Add(new Position(48.12695, -1.64662));
				JourneyMap.RouteCoordinates.Add(new Position(48.12696, -1.64664));
				JourneyMap.RouteCoordinates.Add(new Position(48.12697, -1.64666));
				JourneyMap.RouteCoordinates.Add(new Position(48.12699, -1.64668));
				JourneyMap.RouteCoordinates.Add(new Position(48.12700, -1.64670));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64671));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64671));
				JourneyMap.RouteCoordinates.Add(new Position(48.12702, -1.64672));
				JourneyMap.RouteCoordinates.Add(new Position(48.12702, -1.64672));
				JourneyMap.RouteCoordinates.Add(new Position(48.12702, -1.64672));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64672));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64672));
				JourneyMap.RouteCoordinates.Add(new Position(48.12701, -1.64672));
			}

			JourneyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(48.12706, -1.64831), Distance.FromKilometers(2.0f)));

		}
	}
}