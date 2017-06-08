﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpTibiaProxy.Domain;

namespace SharpTibiaProxy
{
    public class Constants
    {
        public static string AppDataPath = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SharpTibiaProxy");

        public enum LoginStatus : byte
        {
            LoggedOut = 0,
            NotLoggedIn = LoggedOut,
            LoggingIn = 6,
            LoggedIn = 11
        }

        public static class RSAKey
        {
            public static string OpenTibiaP = "14299623962416399520070177382898895550795403345466153217470516082934737582776038882967213386204600674145392845853859217990626450972452084065728686565928113";
            public static string OpenTibiaQ = "7630979195970404721891201847792002125535401292779123937207447574596692788513647179235335529307251350570728407373705564708871762033017096809910315212884101";
            public static string OpenTibiaDP = "11141736698610418925078406669215087697114858422461871124661098818361832856659225315773346115219673296375487744032858798960485665997181641221483584094519937";
            public static string OpenTibiaDQ = "4886309137722172729208909250386672706991365415741885286554321031904881408516947737562153523770981322408725111241551398797744838697461929408240938369297973";
            public static string OpenTibiaInverseQ = "5610960212328996596431206032772162188356793727360507633581722789998709372832546447914318965787194031968482458122348411654607397146261039733584248408719418";
            public static string OpenTibiaM = "109120132967399429278860960508995541528237502902798129123468757937266291492576446330739696001110603907230888610072655818825358503429057592827629436413108566029093628212635953836686562675849720620786279431090218017681061521755056710823876476444260558147179707119674283982419152118103759076030616683978566631413";
            public static string OpenTibiaE = "65537";

            public static string RealTibiaM = "132127743205872284062295099082293384952776326496165507967876361843343953435544496682053323833394351797728954155097012103928360786959821132214473291575712138800495033169914814069637740318278150290733684032524174782740134357629699062987023311132821016569775488792221429527047321331896351555606801473202394175817";
            public static string RealTibiaE = "65537";
        }
    }
}