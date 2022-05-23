import { Component, OnInit } from '@angular/core';
import { DadosGeraisService } from '../dados-gerais.service';
import { IDados, IMedias } from '../medias.interface';

@Component({
  selector: 'app-dados-gerais',
  templateUrl: './dados-gerais.component.html',
  styleUrls: ['./dados-gerais.component.css']
})
export class DadosGeraisComponent implements OnInit {

  casos: IDados[] = [];
  constructor(private dadosGeraisService : DadosGeraisService) { }

  ngOnInit(): void {
    this.listarTodosOsCasos();
  }

  listarTodosOsCasos(){
    this.dadosGeraisService.listarTodosOsCasos().subscribe((data)=> this.casos = data as [])
  }

}
