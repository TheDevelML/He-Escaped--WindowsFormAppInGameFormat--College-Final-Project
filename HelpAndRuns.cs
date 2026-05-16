
using System;
using System.Drawing;
using System.Windows.Forms;

namespace He_escaped
{
    // -------------------------------------------------------------------------
    //  HelpForm — standalone scrollable window
    // -------------------------------------------------------------------------
    public class HelpForm : Form
    {
        public HelpForm()
        {
            // ── Window setup ─────────────────────────────────────────────────
            this.Text            = "How to Survive";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.BackColor       = Color.FromArgb(30, 30, 30);

            // Size to 60 % of screen height, capped at 700 px tall, 520 px wide.
            int screenH = Screen.PrimaryScreen.WorkingArea.Height;
            int formH   = Math.Min(700, (int)(screenH * 0.60));
            this.ClientSize = new Size(520, formH);

            // ── RichTextBox (scrollable) ──────────────────────────────────────
            RichTextBox rtb = new RichTextBox
            {
                ReadOnly        = true,
                ScrollBars      = RichTextBoxScrollBars.Vertical,
                BorderStyle     = BorderStyle.None,
                BackColor       = Color.FromArgb(30, 30, 30),
                ForeColor       = Color.WhiteSmoke,
                Font            = new Font("Segoe UI", 9.5f),
                Dock            = DockStyle.Fill,
                WordWrap        = true,
                DetectUrls      = false,
                ShortcutsEnabled = false,
            };

            // ── Close button ─────────────────────────────────────────────────
            Button btnClose = new Button
            {
                Text      = "Close",
                Dock      = DockStyle.Bottom,
                Height    = 34,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(60, 60, 60),
                ForeColor = Color.WhiteSmoke,
                Font      = new Font("Segoe UI", 9f, FontStyle.Bold),
            };
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(rtb);
            this.Controls.Add(btnClose);

            // ── Populate text ─────────────────────────────────────────────────
            BuildHelpText(rtb);

            // Scroll back to the top after building.
            rtb.SelectionStart = 0;
            rtb.ScrollToCaret();
        }

        // Writes colour-coded sections into the RichTextBox.
        private void BuildHelpText(RichTextBox rtb)
        {
            // Helper lambdas so the call-sites stay readable.
            void Heading(string text)
            {
                rtb.SelectionFont  = new Font("Segoe UI", 10.5f, FontStyle.Bold);
                rtb.SelectionColor = Color.Gold;
                rtb.AppendText(text + "\n");
                rtb.SelectionFont  = new Font("Segoe UI", 9.5f);
                rtb.SelectionColor = Color.WhiteSmoke;
            }

            void Body(string text)
            {
                rtb.SelectionFont  = new Font("Segoe UI", 9.5f);
                rtb.SelectionColor = Color.WhiteSmoke;
                rtb.AppendText(text + "\n");
            }

            void Bullet(string label, string detail, Color labelColor)
            {
                // Label part (coloured)
                rtb.SelectionFont  = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                rtb.SelectionColor = labelColor;
                rtb.AppendText("  • " + label);

                // Detail part (normal)
                rtb.SelectionFont  = new Font("Segoe UI", 9.5f);
                rtb.SelectionColor = Color.WhiteSmoke;
                rtb.AppendText(detail + "\n");
            }

            void Gap() => rtb.AppendText("\n");

            // ── Content ───────────────────────────────────────────────────────

            Heading("HOW TO SURVIVE");
            Body("You are guiding something across a brutal path.");
            Body("Your goal: reach the City at the end of Run 3 before it all falls apart.");
            Gap();

            Heading("THE JOURNEY — 3 RUNS OF 100 TILES");
            Body("The board resets between runs, but your stats, inventory, and gold carry over.");
            Body("Each run is harder than the last — more danger, more item loss, fewer safe stops.");
            Gap();
            Bullet("Run 1:", " manageable. Learn the ropes.", Color.LightGreen);
            Bullet("Run 2:", " nastier. More damage tiles and item loss.", Color.Orange);
            Bullet("Run 3:", " brutal. The City tile waits at tile 100. Reach it to win.", Color.OrangeRed);
            Gap();

            Heading("TURN FLOW");
            Body("1. Roll the dice — your stats drain every roll.");
            Body("2. Move forward the rolled amount (may be reduced by low stats).");
            Body("3. Resolve whatever tile you land on.");
            Body("4. Repeat until you win or collapse.");
            Gap();

            Heading("STATS");
            Bullet("Health:",  " hits 0 and the game ends.", Color.Tomato);
            Bullet("Energy:",  " at 1 or lower, movement drops to 1.", Color.CornflowerBlue);
            Bullet("Hunger:",  " empty = half movement and HP drain each turn.", Color.SandyBrown);
            Bullet("Thirst:",  " empty = half movement and HP drain each turn.", Color.SkyBlue);
            Body("An  !  appears next to any stat that has hit zero.");
            Gap();

            Heading("TILES");
            Bullet("Blue   — Choice:",     " Rest, Scavenge, Hunt, Craft, or Use Item.", Color.LightBlue);
            Bullet("Orange — RandomEvent:", " something happens. Could be good. Probably isn't.", Color.Orange);
            Bullet("Red    — LoseItem:",    " you drop something. A Satchel can block this once.", Color.Tomato);
            Bullet("Gold   — Merchant:",    " a shop with 3 random items. Spend wisely.", Color.Gold);
            Bullet("DkRed  — HpLoss:",      " take damage. A prepared Weapon blocks this once.", Color.OrangeRed);
            Bullet("Purple — City:",        " the finish line. Only appears at the end of Run 3.", Color.MediumPurple);
            Bullet("Grey   — Empty:",       " nothing happens. Enjoy the quiet.", Color.Silver);
            Gap();

            Heading("ACTIONS (Choice tile only)");
            Bullet("Rest:",     " +20 Energy, +5 HP. Sleeping Bag gives full Energy instead.", Color.LightGreen);
            Bullet("Scavenge:", " search for loot. Usually Sticks or Stones. Sometimes pain.", Color.LightGreen);
            Bullet("Hunt:",     " 75 % chance of Meat (and sometimes Hide). Failure hurts.", Color.LightGreen);
            Bullet("Craft:",    " combine inventory items into something more useful.", Color.LightGreen);
            Bullet("Use Item:", " select one item in the list and activate it.", Color.LightGreen);
            Gap();

            Heading("ITEMS");
            Bullet("Stick / Stone:",    " crafting ingredients. Hoard them.", Color.BurlyWood);
            Bullet("Food:",             " +25 Hunger.", Color.BurlyWood);
            Bullet("Dirty Water:",      " +15 Thirst, -5 HP. Desperate times.", Color.BurlyWood);
            Bullet("Purified Water:",   " +30 Thirst. No strings attached.", Color.BurlyWood);
            Bullet("Meat:",             " +20 Hunger, -5 HP raw.", Color.BurlyWood);
            Bullet("Cooked Meat:",      " +35 Hunger. Safe.", Color.BurlyWood);
            Bullet("Hide:",             " craft with it or sell for 25 gold.", Color.BurlyWood);
            Bullet("Bandage:",          " +15 HP.", Color.BurlyWood);
            Bullet("Potion:",           " +10 Max HP, +10 Max Energy, heals both.", Color.BurlyWood);
            Bullet("Satchel:",          " blocks the next LoseItem tile automatically.", Color.BurlyWood);
            Bullet("Sleeping Bag:",     " full Energy restore on next Rest. One use.", Color.BurlyWood);
            Bullet("Carriage Ticket:",  " next roll is 2 dice combined.", Color.BurlyWood);
            Bullet("Breadcrumbs:",      " move back 1–6 spaces (you choose).", Color.BurlyWood);
            Bullet("Weapon:",           " blocks the next HpLoss tile or attack event.", Color.BurlyWood);
            Bullet("Campfire:",         " on next roll: +15 HP, purifies Dirty Water, cooks Meat.", Color.BurlyWood);
            Gap();

            Heading("CRAFTING RECIPES");
            Bullet("Weapon:",       " Stick + Stone", Color.LightCyan);
            Bullet("Bandage:",      " Hide + Food", Color.LightCyan);
            Bullet("Satchel:",      " Hide + Stone", Color.LightCyan);
            Bullet("Sleeping Bag:", " Hide + Hide", Color.LightCyan);
            Bullet("Campfire:",     " 5 Stick + 5 Stone", Color.LightCyan);
            Body("Select ingredients in the inventory list (Ctrl+click for multiple), then press Craft.");
            Gap();

            Heading("TIPS");
            Body("• Stock up on Potions — they raise your maximums permanently.");
            Body("• A Campfire before a long stretch can turn raw supplies into proper ones.");
            Body("• Save your Satchel and Weapon for Runs 2 and 3 when danger spikes.");
            Body("• Breadcrumbs are niche but can save you from a bad tile cluster.");
            Gap();

            Body("Reach the city. Or don't.");
        }
    }
}
