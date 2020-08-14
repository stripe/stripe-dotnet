namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReportRunParametersOptions : INestedOptions
    {
        /// <summary>
        /// The set of report columns to include in the report output. If omitted, the Report Type
        /// is run with its default column set.
        /// </summary>
        [JsonProperty("columns")]
        public List<string> Columns { get; set; }

        /// <summary>
        /// Connected account ID to filter for in the report run.
        /// </summary>
        [JsonProperty("connected_account")]
        public string ConnectedAccount { get; set; }

        /// <summary>
        /// Currency of objects to be included in the report run.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Ending timestamp of data to be included in the report run (exclusive).
        /// </summary>
        [JsonProperty("interval_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? IntervalEnd { get; set; }

        /// <summary>
        /// Starting timestamp of data to be included in the report run.
        /// </summary>
        [JsonProperty("interval_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? IntervalStart { get; set; }

        /// <summary>
        /// Payout ID by which to filter the report run.
        /// </summary>
        [JsonProperty("payout")]
        public string Payout { get; set; }

        /// <summary>
        /// Category of balance transactions to be included in the report run.
        /// One of: <c>advance</c>, <c>advance_funding</c>, <c>anticipation_repayment</c>,
        /// <c>charge</c>, <c>charge_failure</c>, <c>connect_collection_transfer</c>,
        /// <c>connect_reserved_funds</c>, <c>dispute</c>, <c>dispute_reversal</c>, <c>fee</c>,
        /// <c>financing_paydown</c>, <c>financing_paydown_reversal</c>, <c>financing_payout</c>,
        /// <c>financing_payout_reversal</c>, <c>issuing_authorization_hold</c>,
        /// <c>issuing_authorization_release</c>, <c>issuing_dispute</c>,
        /// <c>issuing_transaction</c>, <c>network_cost</c>, <c>other_adjustment</c>,
        /// <c>partial_capture_reversal</c>, <c>payout</c>, <c>payout_reversal</c>,
        /// <c>platform_earning</c>, <c>platform_earning_refund</c>, <c>refund</c>,
        /// <c>refund_failure</c>, <c>risk_reserved_funds</c>, <c>tax</c>, <c>topup</c>,
        /// <c>topup_reversal</c>, <c>transfer</c>, or <c>transfer_reversal</c>.
        /// </summary>
        [JsonProperty("reporting_category")]
        public string ReportingCategory { get; set; }

        /// <summary>
        /// Defaults to <c>Etc/UTC</c>. The output timezone for all timestamps in the report. A list
        /// of possible time zone values is maintained at the <a
        /// href="http://www.iana.org/time-zones">IANA Time Zone Database</a>. Has no effect on
        /// <c>interval_start</c> or <c>interval_end</c>.
        /// One of: <c>Africa/Abidjan</c>, <c>Africa/Accra</c>, <c>Africa/Addis_Ababa</c>,
        /// <c>Africa/Algiers</c>, <c>Africa/Asmara</c>, <c>Africa/Asmera</c>, <c>Africa/Bamako</c>,
        /// <c>Africa/Bangui</c>, <c>Africa/Banjul</c>, <c>Africa/Bissau</c>,
        /// <c>Africa/Blantyre</c>, <c>Africa/Brazzaville</c>, <c>Africa/Bujumbura</c>,
        /// <c>Africa/Cairo</c>, <c>Africa/Casablanca</c>, <c>Africa/Ceuta</c>,
        /// <c>Africa/Conakry</c>, <c>Africa/Dakar</c>, <c>Africa/Dar_es_Salaam</c>,
        /// <c>Africa/Djibouti</c>, <c>Africa/Douala</c>, <c>Africa/El_Aaiun</c>,
        /// <c>Africa/Freetown</c>, <c>Africa/Gaborone</c>, <c>Africa/Harare</c>,
        /// <c>Africa/Johannesburg</c>, <c>Africa/Juba</c>, <c>Africa/Kampala</c>,
        /// <c>Africa/Khartoum</c>, <c>Africa/Kigali</c>, <c>Africa/Kinshasa</c>,
        /// <c>Africa/Lagos</c>, <c>Africa/Libreville</c>, <c>Africa/Lome</c>, <c>Africa/Luanda</c>,
        /// <c>Africa/Lubumbashi</c>, <c>Africa/Lusaka</c>, <c>Africa/Malabo</c>,
        /// <c>Africa/Maputo</c>, <c>Africa/Maseru</c>, <c>Africa/Mbabane</c>,
        /// <c>Africa/Mogadishu</c>, <c>Africa/Monrovia</c>, <c>Africa/Nairobi</c>,
        /// <c>Africa/Ndjamena</c>, <c>Africa/Niamey</c>, <c>Africa/Nouakchott</c>,
        /// <c>Africa/Ouagadougou</c>, <c>Africa/Porto-Novo</c>, <c>Africa/Sao_Tome</c>,
        /// <c>Africa/Timbuktu</c>, <c>Africa/Tripoli</c>, <c>Africa/Tunis</c>,
        /// <c>Africa/Windhoek</c>, <c>America/Adak</c>, <c>America/Anchorage</c>,
        /// <c>America/Anguilla</c>, <c>America/Antigua</c>, <c>America/Araguaina</c>,
        /// <c>America/Argentina/Buenos_Aires</c>, <c>America/Argentina/Catamarca</c>,
        /// <c>America/Argentina/ComodRivadavia</c>, <c>America/Argentina/Cordoba</c>,
        /// <c>America/Argentina/Jujuy</c>, <c>America/Argentina/La_Rioja</c>,
        /// <c>America/Argentina/Mendoza</c>, <c>America/Argentina/Rio_Gallegos</c>,
        /// <c>America/Argentina/Salta</c>, <c>America/Argentina/San_Juan</c>,
        /// <c>America/Argentina/San_Luis</c>, <c>America/Argentina/Tucuman</c>,
        /// <c>America/Argentina/Ushuaia</c>, <c>America/Aruba</c>, <c>America/Asuncion</c>,
        /// <c>America/Atikokan</c>, <c>America/Atka</c>, <c>America/Bahia</c>,
        /// <c>America/Bahia_Banderas</c>, <c>America/Barbados</c>, <c>America/Belem</c>,
        /// <c>America/Belize</c>, <c>America/Blanc-Sablon</c>, <c>America/Boa_Vista</c>,
        /// <c>America/Bogota</c>, <c>America/Boise</c>, <c>America/Buenos_Aires</c>,
        /// <c>America/Cambridge_Bay</c>, <c>America/Campo_Grande</c>, <c>America/Cancun</c>,
        /// <c>America/Caracas</c>, <c>America/Catamarca</c>, <c>America/Cayenne</c>,
        /// <c>America/Cayman</c>, <c>America/Chicago</c>, <c>America/Chihuahua</c>,
        /// <c>America/Coral_Harbour</c>, <c>America/Cordoba</c>, <c>America/Costa_Rica</c>,
        /// <c>America/Creston</c>, <c>America/Cuiaba</c>, <c>America/Curacao</c>,
        /// <c>America/Danmarkshavn</c>, <c>America/Dawson</c>, <c>America/Dawson_Creek</c>,
        /// <c>America/Denver</c>, <c>America/Detroit</c>, <c>America/Dominica</c>,
        /// <c>America/Edmonton</c>, <c>America/Eirunepe</c>, <c>America/El_Salvador</c>,
        /// <c>America/Ensenada</c>, <c>America/Fort_Nelson</c>, <c>America/Fort_Wayne</c>,
        /// <c>America/Fortaleza</c>, <c>America/Glace_Bay</c>, <c>America/Godthab</c>,
        /// <c>America/Goose_Bay</c>, <c>America/Grand_Turk</c>, <c>America/Grenada</c>,
        /// <c>America/Guadeloupe</c>, <c>America/Guatemala</c>, <c>America/Guayaquil</c>,
        /// <c>America/Guyana</c>, <c>America/Halifax</c>, <c>America/Havana</c>,
        /// <c>America/Hermosillo</c>, <c>America/Indiana/Indianapolis</c>,
        /// <c>America/Indiana/Knox</c>, <c>America/Indiana/Marengo</c>,
        /// <c>America/Indiana/Petersburg</c>, <c>America/Indiana/Tell_City</c>,
        /// <c>America/Indiana/Vevay</c>, <c>America/Indiana/Vincennes</c>,
        /// <c>America/Indiana/Winamac</c>, <c>America/Indianapolis</c>, <c>America/Inuvik</c>,
        /// <c>America/Iqaluit</c>, <c>America/Jamaica</c>, <c>America/Jujuy</c>,
        /// <c>America/Juneau</c>, <c>America/Kentucky/Louisville</c>,
        /// <c>America/Kentucky/Monticello</c>, <c>America/Knox_IN</c>, <c>America/Kralendijk</c>,
        /// <c>America/La_Paz</c>, <c>America/Lima</c>, <c>America/Los_Angeles</c>,
        /// <c>America/Louisville</c>, <c>America/Lower_Princes</c>, <c>America/Maceio</c>,
        /// <c>America/Managua</c>, <c>America/Manaus</c>, <c>America/Marigot</c>,
        /// <c>America/Martinique</c>, <c>America/Matamoros</c>, <c>America/Mazatlan</c>,
        /// <c>America/Mendoza</c>, <c>America/Menominee</c>, <c>America/Merida</c>,
        /// <c>America/Metlakatla</c>, <c>America/Mexico_City</c>, <c>America/Miquelon</c>,
        /// <c>America/Moncton</c>, <c>America/Monterrey</c>, <c>America/Montevideo</c>,
        /// <c>America/Montreal</c>, <c>America/Montserrat</c>, <c>America/Nassau</c>,
        /// <c>America/New_York</c>, <c>America/Nipigon</c>, <c>America/Nome</c>,
        /// <c>America/Noronha</c>, <c>America/North_Dakota/Beulah</c>,
        /// <c>America/North_Dakota/Center</c>, <c>America/North_Dakota/New_Salem</c>,
        /// <c>America/Ojinaga</c>, <c>America/Panama</c>, <c>America/Pangnirtung</c>,
        /// <c>America/Paramaribo</c>, <c>America/Phoenix</c>, <c>America/Port-au-Prince</c>,
        /// <c>America/Port_of_Spain</c>, <c>America/Porto_Acre</c>, <c>America/Porto_Velho</c>,
        /// <c>America/Puerto_Rico</c>, <c>America/Punta_Arenas</c>, <c>America/Rainy_River</c>,
        /// <c>America/Rankin_Inlet</c>, <c>America/Recife</c>, <c>America/Regina</c>,
        /// <c>America/Resolute</c>, <c>America/Rio_Branco</c>, <c>America/Rosario</c>,
        /// <c>America/Santa_Isabel</c>, <c>America/Santarem</c>, <c>America/Santiago</c>,
        /// <c>America/Santo_Domingo</c>, <c>America/Sao_Paulo</c>, <c>America/Scoresbysund</c>,
        /// <c>America/Shiprock</c>, <c>America/Sitka</c>, <c>America/St_Barthelemy</c>,
        /// <c>America/St_Johns</c>, <c>America/St_Kitts</c>, <c>America/St_Lucia</c>,
        /// <c>America/St_Thomas</c>, <c>America/St_Vincent</c>, <c>America/Swift_Current</c>,
        /// <c>America/Tegucigalpa</c>, <c>America/Thule</c>, <c>America/Thunder_Bay</c>,
        /// <c>America/Tijuana</c>, <c>America/Toronto</c>, <c>America/Tortola</c>,
        /// <c>America/Vancouver</c>, <c>America/Virgin</c>, <c>America/Whitehorse</c>,
        /// <c>America/Winnipeg</c>, <c>America/Yakutat</c>, <c>America/Yellowknife</c>,
        /// <c>Antarctica/Casey</c>, <c>Antarctica/Davis</c>, <c>Antarctica/DumontDUrville</c>,
        /// <c>Antarctica/Macquarie</c>, <c>Antarctica/Mawson</c>, <c>Antarctica/McMurdo</c>,
        /// <c>Antarctica/Palmer</c>, <c>Antarctica/Rothera</c>, <c>Antarctica/South_Pole</c>,
        /// <c>Antarctica/Syowa</c>, <c>Antarctica/Troll</c>, <c>Antarctica/Vostok</c>,
        /// <c>Arctic/Longyearbyen</c>, <c>Asia/Aden</c>, <c>Asia/Almaty</c>, <c>Asia/Amman</c>,
        /// <c>Asia/Anadyr</c>, <c>Asia/Aqtau</c>, <c>Asia/Aqtobe</c>, <c>Asia/Ashgabat</c>,
        /// <c>Asia/Ashkhabad</c>, <c>Asia/Atyrau</c>, <c>Asia/Baghdad</c>, <c>Asia/Bahrain</c>,
        /// <c>Asia/Baku</c>, <c>Asia/Bangkok</c>, <c>Asia/Barnaul</c>, <c>Asia/Beirut</c>,
        /// <c>Asia/Bishkek</c>, <c>Asia/Brunei</c>, <c>Asia/Calcutta</c>, <c>Asia/Chita</c>,
        /// <c>Asia/Choibalsan</c>, <c>Asia/Chongqing</c>, <c>Asia/Chungking</c>,
        /// <c>Asia/Colombo</c>, <c>Asia/Dacca</c>, <c>Asia/Damascus</c>, <c>Asia/Dhaka</c>,
        /// <c>Asia/Dili</c>, <c>Asia/Dubai</c>, <c>Asia/Dushanbe</c>, <c>Asia/Famagusta</c>,
        /// <c>Asia/Gaza</c>, <c>Asia/Harbin</c>, <c>Asia/Hebron</c>, <c>Asia/Ho_Chi_Minh</c>,
        /// <c>Asia/Hong_Kong</c>, <c>Asia/Hovd</c>, <c>Asia/Irkutsk</c>, <c>Asia/Istanbul</c>,
        /// <c>Asia/Jakarta</c>, <c>Asia/Jayapura</c>, <c>Asia/Jerusalem</c>, <c>Asia/Kabul</c>,
        /// <c>Asia/Kamchatka</c>, <c>Asia/Karachi</c>, <c>Asia/Kashgar</c>, <c>Asia/Kathmandu</c>,
        /// <c>Asia/Katmandu</c>, <c>Asia/Khandyga</c>, <c>Asia/Kolkata</c>,
        /// <c>Asia/Krasnoyarsk</c>, <c>Asia/Kuala_Lumpur</c>, <c>Asia/Kuching</c>,
        /// <c>Asia/Kuwait</c>, <c>Asia/Macao</c>, <c>Asia/Macau</c>, <c>Asia/Magadan</c>,
        /// <c>Asia/Makassar</c>, <c>Asia/Manila</c>, <c>Asia/Muscat</c>, <c>Asia/Nicosia</c>,
        /// <c>Asia/Novokuznetsk</c>, <c>Asia/Novosibirsk</c>, <c>Asia/Omsk</c>, <c>Asia/Oral</c>,
        /// <c>Asia/Phnom_Penh</c>, <c>Asia/Pontianak</c>, <c>Asia/Pyongyang</c>, <c>Asia/Qatar</c>,
        /// <c>Asia/Qostanay</c>, <c>Asia/Qyzylorda</c>, <c>Asia/Rangoon</c>, <c>Asia/Riyadh</c>,
        /// <c>Asia/Saigon</c>, <c>Asia/Sakhalin</c>, <c>Asia/Samarkand</c>, <c>Asia/Seoul</c>,
        /// <c>Asia/Shanghai</c>, <c>Asia/Singapore</c>, <c>Asia/Srednekolymsk</c>,
        /// <c>Asia/Taipei</c>, <c>Asia/Tashkent</c>, <c>Asia/Tbilisi</c>, <c>Asia/Tehran</c>,
        /// <c>Asia/Tel_Aviv</c>, <c>Asia/Thimbu</c>, <c>Asia/Thimphu</c>, <c>Asia/Tokyo</c>,
        /// <c>Asia/Tomsk</c>, <c>Asia/Ujung_Pandang</c>, <c>Asia/Ulaanbaatar</c>,
        /// <c>Asia/Ulan_Bator</c>, <c>Asia/Urumqi</c>, <c>Asia/Ust-Nera</c>, <c>Asia/Vientiane</c>,
        /// <c>Asia/Vladivostok</c>, <c>Asia/Yakutsk</c>, <c>Asia/Yangon</c>,
        /// <c>Asia/Yekaterinburg</c>, <c>Asia/Yerevan</c>, <c>Atlantic/Azores</c>,
        /// <c>Atlantic/Bermuda</c>, <c>Atlantic/Canary</c>, <c>Atlantic/Cape_Verde</c>,
        /// <c>Atlantic/Faeroe</c>, <c>Atlantic/Faroe</c>, <c>Atlantic/Jan_Mayen</c>,
        /// <c>Atlantic/Madeira</c>, <c>Atlantic/Reykjavik</c>, <c>Atlantic/South_Georgia</c>,
        /// <c>Atlantic/St_Helena</c>, <c>Atlantic/Stanley</c>, <c>Australia/ACT</c>,
        /// <c>Australia/Adelaide</c>, <c>Australia/Brisbane</c>, <c>Australia/Broken_Hill</c>,
        /// <c>Australia/Canberra</c>, <c>Australia/Currie</c>, <c>Australia/Darwin</c>,
        /// <c>Australia/Eucla</c>, <c>Australia/Hobart</c>, <c>Australia/LHI</c>,
        /// <c>Australia/Lindeman</c>, <c>Australia/Lord_Howe</c>, <c>Australia/Melbourne</c>,
        /// <c>Australia/NSW</c>, <c>Australia/North</c>, <c>Australia/Perth</c>,
        /// <c>Australia/Queensland</c>, <c>Australia/South</c>, <c>Australia/Sydney</c>,
        /// <c>Australia/Tasmania</c>, <c>Australia/Victoria</c>, <c>Australia/West</c>,
        /// <c>Australia/Yancowinna</c>, <c>Brazil/Acre</c>, <c>Brazil/DeNoronha</c>,
        /// <c>Brazil/East</c>, <c>Brazil/West</c>, <c>CET</c>, <c>CST6CDT</c>,
        /// <c>Canada/Atlantic</c>, <c>Canada/Central</c>, <c>Canada/Eastern</c>,
        /// <c>Canada/Mountain</c>, <c>Canada/Newfoundland</c>, <c>Canada/Pacific</c>,
        /// <c>Canada/Saskatchewan</c>, <c>Canada/Yukon</c>, <c>Chile/Continental</c>,
        /// <c>Chile/EasterIsland</c>, <c>Cuba</c>, <c>EET</c>, <c>EST</c>, <c>EST5EDT</c>,
        /// <c>Egypt</c>, <c>Eire</c>, <c>Etc/GMT</c>, <c>Etc/GMT+0</c>, <c>Etc/GMT+1</c>,
        /// <c>Etc/GMT+10</c>, <c>Etc/GMT+11</c>, <c>Etc/GMT+12</c>, <c>Etc/GMT+2</c>,
        /// <c>Etc/GMT+3</c>, <c>Etc/GMT+4</c>, <c>Etc/GMT+5</c>, <c>Etc/GMT+6</c>,
        /// <c>Etc/GMT+7</c>, <c>Etc/GMT+8</c>, <c>Etc/GMT+9</c>, <c>Etc/GMT-0</c>,
        /// <c>Etc/GMT-1</c>, <c>Etc/GMT-10</c>, <c>Etc/GMT-11</c>, <c>Etc/GMT-12</c>,
        /// <c>Etc/GMT-13</c>, <c>Etc/GMT-14</c>, <c>Etc/GMT-2</c>, <c>Etc/GMT-3</c>,
        /// <c>Etc/GMT-4</c>, <c>Etc/GMT-5</c>, <c>Etc/GMT-6</c>, <c>Etc/GMT-7</c>,
        /// <c>Etc/GMT-8</c>, <c>Etc/GMT-9</c>, <c>Etc/GMT0</c>, <c>Etc/Greenwich</c>,
        /// <c>Etc/UCT</c>, <c>Etc/UTC</c>, <c>Etc/Universal</c>, <c>Etc/Zulu</c>,
        /// <c>Europe/Amsterdam</c>, <c>Europe/Andorra</c>, <c>Europe/Astrakhan</c>,
        /// <c>Europe/Athens</c>, <c>Europe/Belfast</c>, <c>Europe/Belgrade</c>,
        /// <c>Europe/Berlin</c>, <c>Europe/Bratislava</c>, <c>Europe/Brussels</c>,
        /// <c>Europe/Bucharest</c>, <c>Europe/Budapest</c>, <c>Europe/Busingen</c>,
        /// <c>Europe/Chisinau</c>, <c>Europe/Copenhagen</c>, <c>Europe/Dublin</c>,
        /// <c>Europe/Gibraltar</c>, <c>Europe/Guernsey</c>, <c>Europe/Helsinki</c>,
        /// <c>Europe/Isle_of_Man</c>, <c>Europe/Istanbul</c>, <c>Europe/Jersey</c>,
        /// <c>Europe/Kaliningrad</c>, <c>Europe/Kiev</c>, <c>Europe/Kirov</c>,
        /// <c>Europe/Lisbon</c>, <c>Europe/Ljubljana</c>, <c>Europe/London</c>,
        /// <c>Europe/Luxembourg</c>, <c>Europe/Madrid</c>, <c>Europe/Malta</c>,
        /// <c>Europe/Mariehamn</c>, <c>Europe/Minsk</c>, <c>Europe/Monaco</c>,
        /// <c>Europe/Moscow</c>, <c>Europe/Nicosia</c>, <c>Europe/Oslo</c>, <c>Europe/Paris</c>,
        /// <c>Europe/Podgorica</c>, <c>Europe/Prague</c>, <c>Europe/Riga</c>, <c>Europe/Rome</c>,
        /// <c>Europe/Samara</c>, <c>Europe/San_Marino</c>, <c>Europe/Sarajevo</c>,
        /// <c>Europe/Saratov</c>, <c>Europe/Simferopol</c>, <c>Europe/Skopje</c>,
        /// <c>Europe/Sofia</c>, <c>Europe/Stockholm</c>, <c>Europe/Tallinn</c>,
        /// <c>Europe/Tirane</c>, <c>Europe/Tiraspol</c>, <c>Europe/Ulyanovsk</c>,
        /// <c>Europe/Uzhgorod</c>, <c>Europe/Vaduz</c>, <c>Europe/Vatican</c>,
        /// <c>Europe/Vienna</c>, <c>Europe/Vilnius</c>, <c>Europe/Volgograd</c>,
        /// <c>Europe/Warsaw</c>, <c>Europe/Zagreb</c>, <c>Europe/Zaporozhye</c>,
        /// <c>Europe/Zurich</c>, <c>Factory</c>, <c>GB</c>, <c>GB-Eire</c>, <c>GMT</c>,
        /// <c>GMT+0</c>, <c>GMT-0</c>, <c>GMT0</c>, <c>Greenwich</c>, <c>HST</c>, <c>Hongkong</c>,
        /// <c>Iceland</c>, <c>Indian/Antananarivo</c>, <c>Indian/Chagos</c>,
        /// <c>Indian/Christmas</c>, <c>Indian/Cocos</c>, <c>Indian/Comoro</c>,
        /// <c>Indian/Kerguelen</c>, <c>Indian/Mahe</c>, <c>Indian/Maldives</c>,
        /// <c>Indian/Mauritius</c>, <c>Indian/Mayotte</c>, <c>Indian/Reunion</c>, <c>Iran</c>,
        /// <c>Israel</c>, <c>Jamaica</c>, <c>Japan</c>, <c>Kwajalein</c>, <c>Libya</c>, <c>MET</c>,
        /// <c>MST</c>, <c>MST7MDT</c>, <c>Mexico/BajaNorte</c>, <c>Mexico/BajaSur</c>,
        /// <c>Mexico/General</c>, <c>NZ</c>, <c>NZ-CHAT</c>, <c>Navajo</c>, <c>PRC</c>,
        /// <c>PST8PDT</c>, <c>Pacific/Apia</c>, <c>Pacific/Auckland</c>,
        /// <c>Pacific/Bougainville</c>, <c>Pacific/Chatham</c>, <c>Pacific/Chuuk</c>,
        /// <c>Pacific/Easter</c>, <c>Pacific/Efate</c>, <c>Pacific/Enderbury</c>,
        /// <c>Pacific/Fakaofo</c>, <c>Pacific/Fiji</c>, <c>Pacific/Funafuti</c>,
        /// <c>Pacific/Galapagos</c>, <c>Pacific/Gambier</c>, <c>Pacific/Guadalcanal</c>,
        /// <c>Pacific/Guam</c>, <c>Pacific/Honolulu</c>, <c>Pacific/Johnston</c>,
        /// <c>Pacific/Kiritimati</c>, <c>Pacific/Kosrae</c>, <c>Pacific/Kwajalein</c>,
        /// <c>Pacific/Majuro</c>, <c>Pacific/Marquesas</c>, <c>Pacific/Midway</c>,
        /// <c>Pacific/Nauru</c>, <c>Pacific/Niue</c>, <c>Pacific/Norfolk</c>,
        /// <c>Pacific/Noumea</c>, <c>Pacific/Pago_Pago</c>, <c>Pacific/Palau</c>,
        /// <c>Pacific/Pitcairn</c>, <c>Pacific/Pohnpei</c>, <c>Pacific/Ponape</c>,
        /// <c>Pacific/Port_Moresby</c>, <c>Pacific/Rarotonga</c>, <c>Pacific/Saipan</c>,
        /// <c>Pacific/Samoa</c>, <c>Pacific/Tahiti</c>, <c>Pacific/Tarawa</c>,
        /// <c>Pacific/Tongatapu</c>, <c>Pacific/Truk</c>, <c>Pacific/Wake</c>,
        /// <c>Pacific/Wallis</c>, <c>Pacific/Yap</c>, <c>Poland</c>, <c>Portugal</c>, <c>ROC</c>,
        /// <c>ROK</c>, <c>Singapore</c>, <c>Turkey</c>, <c>UCT</c>, <c>US/Alaska</c>,
        /// <c>US/Aleutian</c>, <c>US/Arizona</c>, <c>US/Central</c>, <c>US/East-Indiana</c>,
        /// <c>US/Eastern</c>, <c>US/Hawaii</c>, <c>US/Indiana-Starke</c>, <c>US/Michigan</c>,
        /// <c>US/Mountain</c>, <c>US/Pacific</c>, <c>US/Pacific-New</c>, <c>US/Samoa</c>,
        /// <c>UTC</c>, <c>Universal</c>, <c>W-SU</c>, <c>WET</c>, or <c>Zulu</c>.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
