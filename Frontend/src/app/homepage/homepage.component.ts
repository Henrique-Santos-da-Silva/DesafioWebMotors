import { Component, OnInit } from '@angular/core';
import {WebmotorsService} from '../webmotors.service';
import {Anuncio} from '../models/Anuncio';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {

  anuncios: Anuncio[];

  constructor(private service: WebmotorsService, private router: Router,
              private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.getAnuncios();
  }

  getAnuncios() {
    this.service.buscarTodosAnuncios().subscribe(dados => {
      this.anuncios = dados
      console.log(this.anuncios)
    });
  }

  onEdit(id) {
    this.router.navigate(['atualizar', id], {relativeTo: this.route});
  }

  onDelete(anuncio) {
    this.service.removerAnuncio(anuncio.id).subscribe(
      success => {
        this.getAnuncios();
      }
    );
  }
}
