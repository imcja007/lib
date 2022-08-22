import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { addAuthor } from '../models/addAuthor';
import { Author } from '../models/Author';

@Injectable({
  providedIn: 'root',
})
export class AuthorService {
  static getSingleAuthors(id: string | null) {
    throw new Error('Method not implemented.');
  }
  private baseApiUrl = 'https://localhost:7019/';
  constructor(private httpClient: HttpClient) {}

  geAuthors(): Observable<Author[]> {
    var a = this.httpClient.get<Author[]>(this.baseApiUrl + 'controller');
    console.log(a);
    return a;
  }
  deleteAuthor(id: number): Observable<any> {
    var a = this.baseApiUrl + 'controller/' + id;
    location.reload();
    return this.httpClient.delete(a);
  }

  addAuthor(auth: addAuthor): Observable<any> {
    location.reload();
    return this.httpClient.post(
      this.baseApiUrl + 'controller/Author/Add',
      auth
    );
  }
}
