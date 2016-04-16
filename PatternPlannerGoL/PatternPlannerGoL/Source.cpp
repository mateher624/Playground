#include <stdio.h>
#include <stdlib.h>
#include <time.h>
//#include <thread>
//#include <Windows.h>
#include <string.h>
#include <allegro5/allegro.h>
#include <allegro5/allegro_image.h>
#include <allegro5/allegro_font.h>
#include <allegro5/allegro_primitives.h>

#define SCR_WIDTH 800
#define SCR_HEIGHT 600

#define PAINT_WIDTH 40
#define PAINT_HEIGHT 30

typedef enum { False, True } boole;

int saveToFile(int **tab, char * name)
{
	FILE * file;
	errno_t error;

	if (error = fopen_s(&file, name, "w") != 0)
	{
		printf("File was not opened\n");
		return 1;
	}
	else
	{
		for (int i = 0; i < PAINT_WIDTH; i++)
		{
			for (int j = 0; j < PAINT_HEIGHT; j++)
			{
				if (tab[i][j] == 1) fprintf(file, "x%3dy%3d\n", i, j);
			}
		}
		fclose(file);
	}
	return 0;
}

int main(int argc, char** argv)
{
	//ZMIENNE STANU
	int TABLE_WIDTH = 0;
	int TABLE_HEIGHT = 0;
	int POS_X = PAINT_WIDTH / 2;
	int POS_Y = PAINT_HEIGHT / 2;
	int PX_WIDTH = SCR_WIDTH / PAINT_WIDTH;
	int PX_HEIGHT = SCR_HEIGHT / PAINT_HEIGHT;
	boole exit = False;
	srand(time(0));
	printf("Enter name of new pattern:\n");
	char name[20];
	scanf_s("%s", name);
	al_init();
	al_install_keyboard();
	al_install_mouse();
	al_init_image_addon();
	al_init_font_addon();
	//al_init_ttf_addon();
	al_init_primitives_addon();

	int **tab = (int**)malloc(PAINT_WIDTH * sizeof(int*));
	for (int a = 0; a < PAINT_WIDTH; a++)
	{
		tab[a] = (int*)malloc(PAINT_HEIGHT * sizeof(int));
	}

	ALLEGRO_KEYBOARD_STATE klawiatura;
	ALLEGRO_EVENT_QUEUE * key_queue = al_create_event_queue();
	al_register_event_source(key_queue, al_get_keyboard_event_source());

	//al_set_new_display_flags(ALLEGRO_FULLSCREEN);

	ALLEGRO_DISPLAY *okno = al_create_display(SCR_WIDTH, SCR_HEIGHT);
	al_hide_mouse_cursor(okno);
	al_set_window_title(okno, "Game of Life Pattern Planner v. 1.0.0");
	do {
		//ALLEGRO_COLOR color;
		ALLEGRO_EVENT events;
		al_get_keyboard_state(&klawiatura);
		al_clear_to_color(al_map_rgb(0, 0, 0));

		//al_draw_textf(font_console, colors.secondary, (settings.SCR_WIDTH / 2) - 370, settings.SCR_HEIGHT - 40, 0, "(C) Coyrights 2016 by Mateusz Herjan. All rights reserved.");
		
		for (int i = 0; i < PAINT_WIDTH; i++)
		{
			al_draw_line((i * PX_WIDTH), 1, (i * PX_WIDTH), SCR_HEIGHT, al_map_rgb(128, 128, 128), 1);
		}
		for (int i = 0; i < PAINT_WIDTH; i++)
		{
			al_draw_line(1, (i * PX_HEIGHT) , SCR_WIDTH, (i * PX_HEIGHT) , al_map_rgb(128, 128, 128), 1);
		}
		for (int i = 0; i < PAINT_WIDTH; i++)
		{
			for (int j = 0; j < PAINT_HEIGHT; j++)
			{
				if (tab[i][j] == 1) al_draw_filled_rectangle((i+1) * PX_WIDTH, (j + 1) * PX_HEIGHT, (i + 1) * PX_WIDTH + PX_WIDTH, (j + 1) * PX_HEIGHT + PX_HEIGHT, al_map_rgb(255, 255, 255));
			}
		}
		al_draw_filled_rectangle(POS_X * PX_WIDTH, POS_Y * PX_HEIGHT, POS_X * PX_WIDTH + PX_WIDTH, POS_Y * PX_HEIGHT + PX_HEIGHT, al_map_rgb(255, 255, 0));

		al_flip_display();

		al_wait_for_event(key_queue, &events);
		if (events.type == ALLEGRO_EVENT_KEY_DOWN)
		{
			if (events.keyboard.keycode == ALLEGRO_KEY_ESCAPE) exit = True;
			else if (events.keyboard.keycode == ALLEGRO_KEY_ENTER && tab[POS_X-1][POS_Y-1] == 1) tab[POS_X - 1][POS_Y - 1] = 0;
			else if (events.keyboard.keycode == ALLEGRO_KEY_ENTER && tab[POS_X - 1][POS_Y - 1] != 1) tab[POS_X - 1][POS_Y - 1] = 1;
			else if (events.keyboard.keycode == ALLEGRO_KEY_S) saveToFile(tab, name);
			else if (events.keyboard.keycode == ALLEGRO_KEY_DOWN) POS_Y = POS_Y+1;
			else if (events.keyboard.keycode == ALLEGRO_KEY_UP) POS_Y = POS_Y-1;
			else if (events.keyboard.keycode == ALLEGRO_KEY_RIGHT) POS_X = POS_X + 1;
			else if (events.keyboard.keycode == ALLEGRO_KEY_LEFT) POS_X = POS_X - 1;
	
			if (POS_X > PAINT_WIDTH-1) POS_X = PAINT_WIDTH-1;
			if (POS_X < 0) POS_X = 0;
			if (POS_Y > PAINT_HEIGHT-1) POS_Y = PAINT_HEIGHT-1;
			if (POS_Y < 0) POS_Y = 0;
		}
		al_flush_event_queue(key_queue);
	} while (exit == False);
	al_destroy_display(okno);
	for (int i = 0; i < PAINT_WIDTH; i++)
	{
		free(tab[i]);
	}
	free(tab);
	return 0;
}