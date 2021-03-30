import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {Location} from '@angular/common';
import {WebmotorsService} from '../webmotors.service';
import {Marca} from '../models/Marca';
import {Modelo} from '../models/Modelo';
import {Versao} from '../models/Versao';
import {Anuncio} from '../models/Anuncio';
import {ActivatedRoute} from '@angular/router';


@Component({
  selector: 'app-anuncio-formulario',
  templateUrl: './anuncio-formulario.component.html',
  styleUrls: ['./anuncio-formulario.component.css']
})
export class AnuncioFormularioComponent implements OnInit {

  formulario: FormGroup;
  marcas: Marca[];
  modelos: Modelo[];
  versoes: Versao[];
  anuncio = {} as Anuncio;

  // Pegar o nome da marca, modelo e versao, do id selecionado
  marcaFilter;
  modeloFilter;
  versaoFilter;


  constructor(private fb: FormBuilder,
              private service: WebmotorsService,
              private location: Location,
              private route: ActivatedRoute) {
  }

  ngOnInit(): void {


    const anuncio = this.route.snapshot.data['anuncio'];

    this.getMarcas();


    this.formulario = this.fb.group({
      id: [anuncio.id],
      marca: [anuncio.marca, Validators.required],
      modelo: [anuncio.modelo, Validators.required],
      versao: [anuncio.versao, Validators.required],
      ano: [anuncio.ano, Validators.required],
      quilometragem: [anuncio.quilometragem, Validators.required],
      observacao: [anuncio.observacao, Validators.required],
    });

    this.formulario.get('marca').valueChanges
      .subscribe(value => this.getModeloPorMarca(value));

    this.formulario.get('modelo').valueChanges
      .subscribe(value => this.getVersaoDoModelo(value));


  }

  getMarcas() {
    this.service.buscarMarcas().subscribe(dados => {
      this.marcas = dados;
    });
  }

  getModeloPorMarca(id: number) {
    this.service.buscarModeloPorMarca(id).subscribe(dados => {
      this.modelos = dados;
    });
  }

  getVersaoDoModelo(id: number) {
    this.service.buscarVersao(id).subscribe(dados => {
      this.versoes = dados;
    });
  }

  cadastrarAnuncio() {
    this.marcaFilter = this.marcas.filter(m => this.formulario.value.marca == m.ID);
    this.modeloFilter = this.modelos.filter(m => this.formulario.value.modelo == m.ID);
    this.versaoFilter = this.versoes.filter(m => this.formulario.value.versao == m.ID);

    this.anuncio = {
      marca: this.marcaFilter[0].Name,
      modelo: this.modeloFilter[0].Name,
      versao: this.versaoFilter[0].Name,
      ano: this.formulario.value.ano,
      quilometragem: this.formulario.value.quilometragem,
      observacao: this.formulario.value.observacao
    };

    this.service.criarAnuncio(this.anuncio).subscribe(
      success => {
        this.location.back();
      },
      error => console.error(error)
    );
  }

  atualizarAnuncio() {
    this.marcaFilter = this.marcas.filter(m => this.formulario.value.marca == m.ID);
    this.modeloFilter = this.modelos.filter(m => this.formulario.value.modelo == m.ID);
    this.versaoFilter = this.versoes.filter(m => this.formulario.value.versao == m.ID);

    this.formulario.value.marca = this.marcaFilter[0].Name;
    this.formulario.value.modelo = this.modeloFilter[0].Name;
    this.formulario.value.versao = this.versaoFilter[0].Name;


    this.service.atualizarAnuncio(this.formulario.value).subscribe(
      success => {
        this.location.back();
      },
      error => console.error(error)
    );


  }

  onSubmit() {
    if (this.formulario.value.id) {
      this.atualizarAnuncio();
    } else {
      this.cadastrarAnuncio();
    }

  }

  onBackPage() {
    this.location.back();
  }

  onReset() {
    this.formulario.reset();
  }

}
