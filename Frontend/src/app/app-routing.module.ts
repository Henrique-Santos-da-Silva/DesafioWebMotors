import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AppComponent} from './app.component';
import {AnuncioFormularioComponent} from './anuncio-formulario/anuncio-formulario.component';
import {HomepageComponent} from './homepage/homepage.component';
import {AnuncioResolverGuard} from './guards/anuncio-resolver.guard';

const routes: Routes = [
  {path: '', component: HomepageComponent, pathMatch: 'full'},
  {path: 'cadastrar', component: AnuncioFormularioComponent, resolve: {anuncio: AnuncioResolverGuard}},
  {path: 'atualizar/:id', component: AnuncioFormularioComponent, resolve: {anuncio: AnuncioResolverGuard}}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
