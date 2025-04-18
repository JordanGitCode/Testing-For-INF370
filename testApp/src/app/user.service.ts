import { Injectable } from '@angular/core';
import { User } from "./user";
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  users: User[] = [];
  getUrl: string = 'https://localhost:44334/api/User';

  constructor(private http: HttpClient) { }

  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.getUrl);
  }

  getUser(id: number): Observable<User> {
    return this.http.get<User>(`${this.getUrl}/${id}`);
  }

  addUser(user: User): Observable<User> {
    return this.http.post<User>(this.getUrl, user);
  }

  updateUser(id: number, user: User): Observable<User> {
    return this.http.put<User>(`${this.getUrl}/${id}`, user);
  }

  deleteUser(id: number): Observable<User> {
    return this.http.delete<User>(`${this.getUrl}/${id}`);
  }

}
