import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from '../_models/user';
import { Register } from '../_models/register';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  baseUrl = environment.baseUrl + "account/";
  currentUser: User = new User();
  private currentUserSubject = new BehaviorSubject<User>(this.currentUser);
  currentUser$ = this.currentUserSubject.asObservable();

  constructor(private httpClient: HttpClient) { 
    if(this.loggedIn()){
      const user: User = JSON.parse(localStorage.getItem('user'));
      this.setCurrentUser(user);
    }
  }

  login(user: any){
    return this.httpClient.post(this.baseUrl + 'login', user).pipe(
      map((response: User) => {
        const user = response;
        if(user){
          console.log(user);
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSubject.next(user);
        }
      })
    );
  }

  logout(){
    localStorage.removeItem('user');
    this.currentUserSubject.next(null);
  }

  loggedIn(){
    const user: User = JSON.parse(localStorage.getItem('user'));
    return !!user;
  }

  register(register: Register){
    return this.httpClient.post(this.baseUrl + 'register', register).pipe(
      map((response: User) => {
        const user = response;
        if(user){
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSubject.next(user);
        }
      })
    );
  }

  setCurrentUser(user: User){
    this.currentUserSubject.next(user);
  }

  public get currentUserValue(){
    return this.currentUserSubject.value
  }
}
