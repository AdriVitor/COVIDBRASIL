import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MediasMoveisComponent } from './medias-moveis.component';

describe('MediasMoveisComponent', () => {
  let component: MediasMoveisComponent;
  let fixture: ComponentFixture<MediasMoveisComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MediasMoveisComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MediasMoveisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
