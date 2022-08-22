import { Component, OnInit } from '@angular/core';
import { addBook } from 'src/app/models/addBook';
import { BookService } from '../book.service';

@Component({
  selector: 'app-add-books',
  templateUrl: './add-books.component.html',
  styleUrls: ['./add-books.component.css'],
})
export class AddBooksComponent implements OnInit {
  constructor(private bookService: BookService) {}

  ngOnInit(): void {}
  addBook() {
    const book: addBook = {
      title: (<HTMLInputElement>document.getElementById('title')).value,
      category: (<HTMLInputElement>document.getElementById('category')).value,
      publisher: (<HTMLInputElement>document.getElementById('publisher')).value,
      price: parseFloat(
        (<HTMLInputElement>document.getElementById('price')).value
      ),
      dateofissue: (<HTMLInputElement>document.getElementById('doi')).value,
      authorid: parseInt(
        (<HTMLInputElement>document.getElementById('authID')).value
      ),
    };
    this.bookService.addBooks(book).subscribe(
      (response: any) => {
        console.log(response);
      },
      (errorResponse) => {
        console.log(errorResponse);
      }
    );
  }
}
