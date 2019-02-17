using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Mvc;
using ProyectoVotarFutbolista.Models;

namespace ProyectoVotarFutbolista.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String usuario, int estrellasgriezmann, int estrellaskoke, int estrellassaul, int estrellascosta, 
            int estrellaslemar, int estrellasrodrigo, int estrellaslucas, int estrellasoblak, int estrellasgodin, int estrellasmorata)
        {
            ViewData["MENSAJE"] = "¡Gracias " + usuario + " por su voto!";
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Griezmann con " + estrellasgriezmann + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Saúl con " + estrellassaul + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Koke con " + estrellaskoke + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Diego Costa con " + estrellascosta + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Lemar con " + estrellaslemar + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Lucas con " + estrellaslucas + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Oblak con " + estrellasoblak + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Godín con " + estrellasgodin + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Rodrigo con " + estrellasrodrigo + " estrellas");
            Trace.TraceInformation("El usuario " + usuario + " ha votado a Morata con " + estrellasmorata + " estrellas");
            MetricTelemetry metricagriezmann = new MetricTelemetry();
            metricagriezmann.Name = "Votación Griezmann";
            metricagriezmann.Sum = estrellasgriezmann;
            MetricTelemetry metricasaul = new MetricTelemetry();
            metricasaul.Name = "Votación Saul";
            metricasaul.Sum = estrellassaul;
            MetricTelemetry metricakoke = new MetricTelemetry();
            metricakoke.Name = "Votación Koke";
            metricakoke.Sum = estrellaskoke;
            MetricTelemetry metricacosta = new MetricTelemetry();
            metricacosta.Name = "Votación Diego Costa";
            metricacosta.Sum = estrellascosta;
            MetricTelemetry metricalemar = new MetricTelemetry();
            metricalemar.Name = "Votación Lemar";
            metricalemar.Sum = estrellaslemar;
            MetricTelemetry metricarodrigo = new MetricTelemetry();
            metricarodrigo.Name = "Votación Rodrigo";
            metricarodrigo.Sum = estrellasrodrigo;
            MetricTelemetry metricalucas = new MetricTelemetry();
            metricalucas.Name = "Votación Lucas";
            metricalucas.Sum = estrellaslucas;
            MetricTelemetry metricaoblak = new MetricTelemetry();
            metricaoblak.Name = "Votación Oblak";
            metricaoblak.Sum = estrellasoblak;
            MetricTelemetry metricagodin = new MetricTelemetry();
            metricagodin.Name = "Votación Godín";
            metricagodin.Sum = estrellasgodin;
            MetricTelemetry metricamorata = new MetricTelemetry();
            metricamorata.Name = "Votación Morata";
            metricamorata.Sum = estrellasrodrigo;
            TelemetryClient client = new TelemetryClient();
            client.TrackEvent("Evento Votación Griezmann");
            client.TrackMetric(metricagriezmann);
            client.TrackEvent("Evento Votación Koke");
            client.TrackMetric(metricakoke);
            client.TrackEvent("Evento Votación Saúl");
            client.TrackMetric(metricasaul);
            client.TrackEvent("Evento Votación Diego Costa");
            client.TrackMetric(metricacosta);
            client.TrackEvent("Evento Votación Lucas");
            client.TrackMetric(metricalucas);
            client.TrackEvent("Evento Votación Morata");
            client.TrackMetric(metricamorata);
            client.TrackEvent("Evento Votación Oblak");
            client.TrackMetric(metricaoblak);
            client.TrackEvent("Evento Votación Godín");
            client.TrackMetric(metricagodin);
            client.TrackEvent("Evento Votación Rodrigo");
            client.TrackMetric(metricarodrigo);
            client.TrackEvent("Evento Votación Lemar");
            client.TrackMetric(metricalemar);
            return View();
        }
    }
}
