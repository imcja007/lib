import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute } from '@angular/router';
import { AuthorService } from '../authors/author.service';
import { Author } from '../models/Author';

@Component({
  selector: 'app-single-author',
  templateUrl: './single-author.component.html',
  styleUrls: ['./single-author.component.css'],
})
export class SingleAuthorComponent implements OnInit {
  // private id: string;
  authors: Author[] = [];
  displayedColumns: string[] = ['authorID', 'name', 'country', 'delete'];
  dataSource: MatTableDataSource<Author> = new MatTableDataSource<Author>();

  constructor() {}

  ngOnInit(): void {}
}
