import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RouterModule, Router } from '@angular/router';


@Component({
  selector: 'app-cliente-partido',
  templateUrl: './cliente-partido.component.html',
  styleUrls: ['./cliente-partido.component.css']
})
export class ClientePartidoComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }

  details(): void {
		this.router.navigate(['partidos/detallePartido/1']);
  }	

  public listmatches: Array<any>= [
      {
        "dia": "Jueves 14 Junio",
        "info": [ {
                    "fecha":"14 jun. 2018",
                    "grupo":"Grupo A",
                    "estadio":"Ekaterinburg Arena",
                    "ciudad": "EKATERINBURG",
                    "equipo1": "Egipto",
                    "bandera1": "../../../assets/banderas/egy.png",
                    "hora": "08:00",
                    "equipo2": "Uruguay",
                    "bandera2": "../../../assets/banderas/uru.png"
                  },
                  {
                    "fecha":"14 jun. 2018",
                    "grupo":"Grupo B",
                    "estadio":"estadio de San Petersburgo",
                    "ciudad": "ST. PETERSBURG",
                    "equipo1": "Marruecos",
                    "bandera1": "../../../assets/banderas/mar.png",
                    "hora": "11:00",
                    "equipo2": "RI de Irán",
                    "bandera2": "../../../assets/banderas/irn.png"
                  },
                  {
                    "fecha":"14 jun. 2018",
                    "grupo":"Grupo B",
                    "estadio":"Fisht Stadium",
                    "ciudad": "SOCHI",
                    "equipo1": "Portugal",
                    "bandera1": "../../../assets/banderas/por.png",
                    "hora": "14:00",
                    "equipo2": "España",
                    "bandera2": "../../../assets/banderas/esp.png"
                  }
                ]
    },
    {
      "dia": "Sábado 16 junio",
      "info": [ {
                  "fecha":"16 jun. 2018",
                  "grupo":"Grupo C",
                  "estadio":"Kazan Arena",
                  "ciudad": "KAZAN",
                  "equipo1": "Francia",
                  "bandera1": "../../../assets/banderas/fra.png",
                  "hora": "06:00",
                  "equipo2": "Australia",
                  "bandera2": "../../../assets/banderas/aus.png"
                },
                {
                  "fecha":"16 jun. 2018",
                  "grupo":"Grupo D",
                  "estadio":"Spartak Stadium",
                  "ciudad": "MOSCOW",
                  "equipo1": "Argentina",
                  "bandera1": "../../../assets/banderas/arg.png",
                  "hora": "09:00",
                  "equipo2": "Islandia",
                  "bandera2": "../../../assets/banderas/isl.png"
                }
                
              ]
  }

  ]
}