import { Component, OnInit } from '@angular/core';
import { UserService } from "../../user.service";
import { Router } from "@angular/router";

@Component({
  selector: 'app-user-listing',
  standalone: false,
  templateUrl: './user-listing.component.html',
  styleUrl: './user-listing.component.css'
})
export class UserListingComponent implements OnInit {
  users: any[] = [];

  constructor(private userService: UserService, private router: Router) { }

  ngOnInit(): void {
    this.userService.getUsers().subscribe((data) => {
      data.sort((a, b) => b.User_ID - a.User_ID);
      this.users = data;
    });
  }

  addUser(): void {
    this.router.navigate(['/add-user']);
  }

  updateUser(id: number): void {
    this.router.navigate(['/edit-user', id]);
  }

  deleteUser(id: number): void {
    this.userService.deleteUser(id).subscribe(() => {
      this.users = this.users.filter(user => user.User_ID !== id);
    }, error => {
      console.error('Error deleting user:', error);
    });
  }

}
