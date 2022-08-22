import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { addBook } from '../models/addBook';
import { Book } from '../models/Book';

@Injectable({
  providedIn: 'root',
})
export class BookService {
  private baseApiUrl = 'https://localhost:7019/book';

  constructor(private httpClient: HttpClient) {}

  getBooks(): Observable<Book[]> {
    return this.httpClient.get<Book[]>(this.baseApiUrl + '');
  }
  addBooks(auth: addBook): Observable<any> {
    // location.reload();
    return this.httpClient.post<addBook>(this.baseApiUrl, auth);
  }
  deleteBook(id: number): Observable<any> {
    var a = this.baseApiUrl + '/' + id;
    console.log(a);

    location.reload();
    return this.httpClient.delete(a);
  }
}
