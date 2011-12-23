package edu.stanford.nick;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;

public class FirstassignmentActivity extends Activity {
	private EditText editText1;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);

		// Store a pointer to editText1. Set up button1 to add a !.
		editText1 = (EditText) findViewById(R.id.editText1);
		Button button = (Button) findViewById(R.id.button1);
		button.setOnClickListener(new OnClickListener() {
			public void onClick(View v) {
				// Lines inside this onClick() method are run
				// when the button is clicked.
				editText1.setText(editText1.getText() + "I love football");
			}
		});
	}
}
