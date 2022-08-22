import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Book } from '../models/Book';
import { BookService } from './book.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css'],
})
export class BooksComponent implements OnInit {
  constructor(private bookservice: BookService) {}


  books: Book[] = [];
  displayedColumns: any[] = [
    'bookId',
    'title',
    'category',
    'publisher',
    'price',
    'dateOfIssue',
    'authorID',
    'delete',
  ];
  dataSource: MatTableDataSource<Book> = new MatTableDataSource<Book>();

  ngOnInit(): void {
    this.bookservice.getBooks().subscribe(
      (Response: any) => {
        console.log(Response);
        this.books = Response;
        this.dataSource = new MatTableDataSource<Book>(this.books);
      },
      (error) => {
        console.log(error);
      }
    );
  }
  Delete(id: number) {
    return this.bookservice.deleteBook(id).subscribe();
  }
  go(id:number){

  }
}
