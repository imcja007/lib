import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorsComponent } from './authors/authors.component';
import { AddBooksComponent } from './books/add-books/add-books.component';
import { BooksComponent } from './books/books.component';
import { HomePComponent } from './home-p/home-p.component';
import { SingleAuthorComponent } from './single-author/single-author.component';

const routes: Routes = [
  { path: '', component: HomePComponent },
  { path: 'author', component: AuthorsComponent },
  { path: 'books', component: BooksComponent },
  { path: 'addBooks', component: AddBooksComponent },
  { path: '**', component: SingleAuthorComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
