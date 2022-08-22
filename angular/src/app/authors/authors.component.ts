import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { AuthorService } from './author.service';
import { Author } from '../models/Author';
import { addAuthor } from '../models/addAuthor';
import { Router } from '@angular/router';

@Component({
  selector: 'app-authors',
  templateUrl: './authors.component.html',
  styleUrls: ['./authors.component.css'],
})
export class AuthorsComponent implements OnInit {
  constructor(private authorService: AuthorService) {}

  authors: Author[] = [];
  displayedColumns: string[] = ['authorID', 'name', 'country', 'delete'];
  dataSource: MatTableDataSource<Author> = new MatTableDataSource<Author>();

  ngOnInit(): void {
    this.authorService.geAuthors().subscribe(
      (response: any) => {
        this.authors = response;
        console.log(response);
        this.dataSource = new MatTableDataSource<Author>(this.authors);
      },
      (errorResponse) => {
        console.log(errorResponse);
      }
    );
  }
  Delete(id: number): void {
    console.log(id);
    this.authorService.deleteAuthor(id).subscribe();
    // this.ngOnInit();
  }
  Add(): void {
    const nameA = prompt('Please enter Author name', 'ex. Joe');
    const countryA = prompt("Please enter Author's country", 'ex. India');

    const auth: addAuthor = {
      name: nameA as string,
      country: countryA as string,
    };

    this.authorService.addAuthor(auth).subscribe(
      (response: any) => {
        console.log(response);
      },
      (errorResponse) => {
        console.log(errorResponse);
      }
    );
  }
}
